using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Meal_Suggestion_App
{
    /// <summary>
    /// Interaction logic for MultipleSuggestions.xaml
    /// </summary>
    public partial class MultipleSuggestions : Window
    {
        public MainWindow ParentWindow { get; private set; }
        private MealSuggestionContainer _context;
        private ViewModel viewModel;

        private int lastBreakfastDish = -1;
        private int lastLunchDish = -1;
        private int lastDinnerDish = -1;
        public MultipleSuggestions(MainWindow parent)
        {
            InitializeComponent();

            //assign the given argument to ParentWindow
            this.ParentWindow = parent;

            //create data context
            _context = new MealSuggestionContainer();

            //set viewModel as data context and create its MealPlans
            viewModel = new ViewModel();
            viewModel.MealPlans = new ObservableCollection<MealPlan>();
            this.DataContext = this.viewModel;
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            //show the ParentWindow and close this window 
            ParentWindow.Show();
            this.Close();
        }

        private void getSuggestionBtn_Click(object sender, RoutedEventArgs e)
        {
            Dish[] breakfasts;
            Dish[] nonBreakfasts;

            //get dishes from database and store them in arrays
            try
            {
                var dishes = from d in _context.Dishes
                             where d.Breakfast == true
                             select d;

                breakfasts = dishes.ToArray<Dish>();

                dishes = from d in _context.Dishes
                         where d.Breakfast == false
                         select d;

                nonBreakfasts = dishes.ToArray<Dish>();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            //when there is not enough dish
            if (nonBreakfasts.Length == 0 || breakfasts.Length == 0)
            {
                MessageBox.Show("Please add dishes (at least 1 breakfast & 1 lunch or dinner) first.");
                return;
            }

            //clear previous suggestions
            viewModel.MealPlans.Clear();

            //generate suggestions
            Random random = new Random();
            for (int i = 0; i < daysSlider.Value; i++)
            {
                int breakfastIndex = random.Next(0, breakfasts.Length);
                //if enough candidates, avoid getting same dish as last breakfast
                if (breakfasts.Length > 1)
                {
                    while (breakfastIndex == lastBreakfastDish)
                    {
                        breakfastIndex = random.Next(0, breakfasts.Length);
                    }
                }
                lastBreakfastDish = breakfastIndex;

                int lunchIndex = random.Next(0, nonBreakfasts.Length);
                //if enough candidates, avoid getting same dish as last lunch
                if (nonBreakfasts.Length > 1)
                {
                    while (lunchIndex == lastLunchDish)
                    {
                        lunchIndex = random.Next(0, nonBreakfasts.Length);
                    }
                }
                lastLunchDish = lunchIndex;

                int dinnerIndex = random.Next(0, nonBreakfasts.Length);
                //if enough candidates, avoid getting same dish as last dinner or this day's lunch
                if (nonBreakfasts.Length > 2)
                {
                    while (dinnerIndex == lastDinnerDish || dinnerIndex == lunchIndex)
                    {
                        dinnerIndex = random.Next(0, nonBreakfasts.Length);
                    }
                }
                lastDinnerDish = dinnerIndex;

                //create new mealPlan and add it to viewModel's MealPlans
                MealPlan mealPlan = new MealPlan
                {
                    Breakfast = breakfasts[breakfastIndex].Name,
                    Lunch = nonBreakfasts[lunchIndex].Name,
                    Dinner = nonBreakfasts[dinnerIndex].Name
                };

                viewModel.MealPlans.Add(mealPlan);

            }

        }
    }
}
