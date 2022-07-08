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
    /// Interaction logic for MultipleSuggestions.xaml
    /// </summary>
    public partial class MultipleSuggestions : Window
    {
        public MainWindow ParentWindow { get; private set; }
        public MultipleSuggestions(MainWindow parent)
        {
            InitializeComponent();

            //assign the given argument to ParentWindow
            this.ParentWindow = parent;
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            //show the ParentWindow and close this window 
            ParentWindow.Show();
            this.Close();
        }
    }
}
