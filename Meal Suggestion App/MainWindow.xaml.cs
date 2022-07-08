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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Meal_Suggestion_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void manageDishesBtn_Click(object sender, RoutedEventArgs e)
        {
            //create and show a Manage Dishes window
            ManageDishes manageDishes = new ManageDishes(this);
            manageDishes.Show();

            //hide this Main Window
            this.Hide();
        }

        private void singleSuggestionBtn_Click(object sender, RoutedEventArgs e)
        {
            //create and show a Single Suggestions window
            SingleSuggestion singleSuggestion = new SingleSuggestion(this);
            singleSuggestion.Show();

            //hide this Main Window
            this.Hide();
        }

        private void multipleSuggestionBtn_Click(object sender, RoutedEventArgs e)
        {
            //create and show a Multiple Suggestions window
            MultipleSuggestions multipleSuggestions = new MultipleSuggestions(this);
            multipleSuggestions.Show();

            //hide this Main Window
            this.Hide();
        }
    }
}
