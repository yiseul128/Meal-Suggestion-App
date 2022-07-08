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
    /// Interaction logic for ManageDishes.xaml
    /// </summary>
    public partial class ManageDishes : Window
    {
        public MainWindow ParentWindow { get; private set; }
        private MealSuggestionContainer _context;

        List<Dish> dishesOnGrid = new List<Dish>();
        int idToDelete = 0;
        public ManageDishes(MainWindow parent)
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

        private void LoadAll()
        {
            //get the dishes from the database and make that the source of dishDataGrid
            var dishes = from d in _context.Dishes select d;
            dishesOnGrid = dishes.ToList<Dish>();
            dishDataGrid.ItemsSource = dishesOnGrid;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //populate dishDataGrid when window loaded
            LoadAll(); 
        }

        private void ClearFields()
        {
            //reset the fields for adding new dish
            nameTxt.Text = "";
            yesRbtn.IsChecked = true;
        }
        private void addDishBtn_Click(object sender, RoutedEventArgs e)
        {
            //when dish name is missing
            if(nameTxt.Text.Trim() == "")
            {
                MessageBox.Show("Please provide the name of a new dish", "Dish Name Missing", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }

            //create dish with provided info
            Dish newDish = new Dish()
            {
                Name = nameTxt.Text,
                Breakfast = (bool)yesRbtn.IsChecked
            };

            //add it to database 
            Dish addedDish = null;
            try
            {
                addedDish = _context.Dishes.Add(newDish);
                _context.SaveChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            if(addedDish != null)
            {
                //refresh dishDataGrid using updated database and reset fields
                LoadAll();
                ClearFields();

                MessageBox.Show("Successfully added dish with ID " + addedDish.Id, "Insertion Successful");
            }

        }

        private void dishDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //if one or more items are selected on dishDataGrid
            if (dishDataGrid.SelectedIndex >= 0 && dishDataGrid.SelectedItems.Count > 0)
            {
                //if selected item's type is Dish class
                if(dishDataGrid.SelectedItems[0].GetType().BaseType == typeof(Dish) 
                    || dishDataGrid.SelectedItems[0].GetType() == typeof(Dish))
                {
                    //get the selected dish and its id
                    Dish selectedDish = (Dish)dishDataGrid.SelectedItems[0];
                    idToDelete = selectedDish.Id;

                    //populate idToDeleteTxt with the id
                    idToDeleteTxt.Text = Convert.ToString(idToDelete);
                }                
            }
        }

        private void deleteDishBtn_Click(object sender, RoutedEventArgs e)
        {
            //when dish to delete is not selected yet
            if(idToDelete == 0)
            {
                MessageBox.Show("Please select a dish to delete", "Dish ID Missing", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }

            //confirm
            MessageBoxResult msgResult = MessageBox.Show("Are you sure to delete this dish?", "Delete Dish",
                MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No);

            if(msgResult == MessageBoxResult.Yes)
            {
                try
                {
                    //find dish to delete from database
                    Dish dishToDelete = (from d in _context.Dishes
                                         where d.Id == this.idToDelete
                                         select d).SingleOrDefault();

                    if(dishToDelete != null)
                    {
                        //delete dish from database
                        _context.Dishes.Remove(dishToDelete);
                        _context.SaveChanges();

                        MessageBox.Show("Successfully deleted dish with ID " + idToDelete, "Deletion Successful");

                        //refresh dishDataGrid using updated database
                        LoadAll();

                        //reset idToDelete
                        idToDelete = 0;
                        idToDeleteTxt.Text = "";
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }

        }
    }
}
