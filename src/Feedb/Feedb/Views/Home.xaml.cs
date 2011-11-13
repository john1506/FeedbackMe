namespace Feedb
{
    using System.Windows.Controls;
    using System.Windows.Navigation;
    using System.Collections.Generic;

    /// <summary>
    /// Home page for the application.
    /// </summary>
    public partial class Home : Page
    {
        /// <summary>
        /// Creates a new <see cref="Home"/> instance.
        /// </summary>
        public Home()
        {
            InitializeComponent();
            ServiceReference1.WizardServiceClient w = new ServiceReference1.WizardServiceClient();
            w.getModuleListCompleted += new System.EventHandler<ServiceReference1.getModuleListCompletedEventArgs>(w_getModuleListCompleted);
            w.getModuleListAsync();
            this.Title = ApplicationStrings.HomePageTitle;
        }

        void w_getModuleListCompleted(object sender, ServiceReference1.getModuleListCompletedEventArgs e)
        {
            var x = e.Result;
            foreach (string s in x)
            {
                moduleBox.Items.Add(s);
            }
          }
         
               


        /// <summary>
        /// Executes when the user navigates to this page.
        /// </summary>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
    }
}