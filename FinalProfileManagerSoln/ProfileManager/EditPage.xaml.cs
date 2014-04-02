using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ProfileManager.Resources;
using Microsoft.WindowsAzure.MobileServices;
using ProfileManager.Model;

namespace ProfileManager
{
    public partial class EditPage : PhoneApplicationPage
    {
        private IMobileServiceTable<UserProfile> userProfileTbl = App.MobileService.GetTable<UserProfile>();

        // Constructor
        public EditPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        // When page is navigated to set data context to selected item in list
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (DataContext == null)
            {
                string selectedIndex = "";
                if (NavigationContext.QueryString.TryGetValue("selectedItem", out selectedIndex))
                {
                    DataContext = App.ViewModel.Items.FirstOrDefault(p => p.ID == selectedIndex);
                }
            }
        }

        private async void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            await userProfileTbl.InsertAsync(new UserProfile() { Name=txtName.Text, Phone=txtPhone.Text, Email=txtEmail.Text});
            App.ViewModel.LoadData();
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}