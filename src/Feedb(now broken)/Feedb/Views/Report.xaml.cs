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
    public partial class Report : Page
    {
        public Report()
        {
            InitializeComponent();
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void qBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void feedbackDomainDataSource_LoadedData(object sender, System.Windows.Controls.LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void sBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox sb = (ComboBox)sender;
            int s = sb.SelectedIndex;
            try
            {
                switch (s)
                {
                    case -1:
                        {
                            dp.Visibility = System.Windows.Visibility.Visible;
                            query.Visibility = System.Windows.Visibility.Collapsed;
                            break;
                        }
                    case 0:
                        {
                            dp.Visibility = System.Windows.Visibility.Visible;
                            query.Visibility = System.Windows.Visibility.Collapsed;
                            break;
                        }
                    case 1:
                        {
                            dp.Visibility = System.Windows.Visibility.Collapsed;
                            query.Visibility = System.Windows.Visibility.Visible;
                            break;
                        }
                    case 2:
                        {
                            dp.Visibility = System.Windows.Visibility.Collapsed;
                            query.Visibility = System.Windows.Visibility.Visible;
                            break;
                        }
                    case 3:
                        {
                            dp.Visibility = System.Windows.Visibility.Collapsed;
                            query.Visibility = System.Windows.Visibility.Visible;
                            break;
                        }
                    default:
                        {
                            dp.Visibility = System.Windows.Visibility.Visible;
                            query.Visibility = System.Windows.Visibility.Collapsed;
                            break;
                        }
                }
            }
            catch (Exception)
            {


            }
        }  
    }
}
