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
            ManageDishes manageDishes = new ManageDishes(this);
            manageDishes.Show();
            this.Hide();
        }

        private void singleSuggestionBtn_Click(object sender, RoutedEventArgs e)
        {
            SingleSuggestion singleSuggestion = new SingleSuggestion(this);
            singleSuggestion.Show();
            this.Hide();
        }

        private void multipleSuggestionBtn_Click(object sender, RoutedEventArgs e)
        {
            MultipleSuggestions multipleSuggestions = new MultipleSuggestions(this);
            multipleSuggestions.Show();
            this.Hide();
        }
    }
}
