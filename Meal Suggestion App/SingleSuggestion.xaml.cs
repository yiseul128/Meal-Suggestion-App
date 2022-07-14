using System;
using System.Collections.Generic;
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
    /// Interaction logic for SingleSuggestion.xaml
    /// </summary>
    public partial class SingleSuggestion : Window
    {
        public MainWindow ParentWindow { get; private set; }
        private MealSuggestionContainer _context;
        int lastDish = -1;
        bool lastBreakfast = true;
        public SingleSuggestion(MainWindow parent)
        {
            InitializeComponent();

            //assign the given argument to ParentWindow
            this.ParentWindow = parent;

            //create data context
            _context = new MealSuggestionContainer();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            //show the ParentWindow and close this window 
            ParentWindow.Show();
            this.Close();
        }

        private void getSuggestionBtn_Click(object sender, RoutedEventArgs e)
        {
            Dish[] candidates;

            try
            {
                //breakfast
                if ((bool)breakfastRbtn.IsChecked)
                {
                    //get dishes for breakfast
                    var dishes = from d in _context.Dishes
                                 where d.Breakfast == true
                                 select d;

                    //populate candidates with them
                    candidates = dishes.ToArray<Dish>();

                    //if users changed dish type (breakfast or not)
                    if (!lastBreakfast)
                    {
                        lastBreakfast = true;

                        //reset index for last dish
                        lastDish = -1;
                    }
                }
                //lunch or dinner
                else
                {
                    //get dishes for lunch or dinner
                    var dishes = from d in _context.Dishes
                                 where d.Breakfast == false
                                 select d;

                    //populate candidates with them
                    candidates = dishes.ToArray<Dish>();

                    //if users changed dish type (breakfast or not)
                    if (lastBreakfast)
                    {
                        lastBreakfast = false;

                        //reset index for last dish
                        lastDish = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            //when no dish in database for selected dish type (breakfast or not)
            if (candidates.Length == 0)
            {
                MessageBox.Show("Please add dishes first.");
                return;
            }

            //get random int for dish index
            Random random = new Random();
            int index = random.Next(0, candidates.Length);

            //make sure users do not same dish right after
            if(candidates.Length > 1)
            {
                while(lastDish == index)
                {
                    index = random.Next(0, candidates.Length);
                }
            }

            //set lastDish with current one
            lastDish = index;

            //display to users
            suggestionTxt.Text = "How about " + candidates[index].Name + "?";
        }
    }
}
