using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Navigation;

namespace Feedb.Views
{
    public partial class Feedback : Page
    {        
        public Feedback()
        {
            InitializeComponent();
            label1.Content = "0";
        }      

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            label1.Content = Math.Floor(slider1.Value);
        }

        private void submitBtn_Click(object sender, RoutedEventArgs e)
        {
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            int p = int.Parse(label1.Content.ToString());
        }
    }
}
