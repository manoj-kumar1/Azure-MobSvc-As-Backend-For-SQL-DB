using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using ProfileManager.Resources;
using Microsoft.WindowsAzure.MobileServices;
using ProfileManager.Model;

namespace ProfileManager.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private IMobileServiceTable<UserProfile> userProfileTbl = App.MobileService.GetTable<UserProfile>();
        private ObservableCollection<ItemViewModel> items;
        public MainViewModel()
        {
            this.Items = new ObservableCollection<ItemViewModel>();
        }

        /// <summary>
        /// A collection for ItemViewModel objects.
        /// </summary>
        public ObservableCollection<ItemViewModel> Items {
            get { return items; }
            private set { items = value; NotifyPropertyChanged("Items"); }
        }

        private string _sampleProperty = "Sample Runtime Property Value";
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding
        /// </summary>
        /// <returns></returns>
        public string SampleProperty
        {
            get
            {
                return _sampleProperty;
            }
            set
            {
                if (value != _sampleProperty)
                {
                    _sampleProperty = value;
                    NotifyPropertyChanged("SampleProperty");
                }
            }
        }

        /// <summary>
        /// Sample property that returns a localized string
        /// </summary>
        public string LocalizedSampleProperty
        {
            get
            {
                return AppResources.SampleProperty;
            }
        }

        public bool IsDataLoaded
        {
            get;
            private set;
        }

        /// <summary>
        /// Creates and adds a few ItemViewModel objects into the Items collection.
        /// </summary>
        public async void LoadData()
        {
            items.Clear();
            // Sample data; replace with real data
            var azureData = true;
            MobileServiceCollection<UserProfile, UserProfile> profiles;
            if (azureData)
            {
                profiles = await userProfileTbl.ToCollectionAsync();

                foreach (var profile in profiles)
                {
                    items.Add(new ItemViewModel() { ID = profile.Id.ToString(), Name = profile.Name, Email = profile.Email, Phone = profile.Phone });
                }
            }
            else
            {
                items.Add(new ItemViewModel() { ID = "0", Name = "Manoj Kumar", Email = "manoj@gmail.com", Phone = "172890567" });
                items.Add(new ItemViewModel() { ID = "1", Name = "User 1", Email = "user1@gmail.com", Phone = "111111111" });
                items.Add(new ItemViewModel() { ID = "2", Name = "User 2", Email = "user2@gmail.com", Phone = "222222222" });
            }
            Items = items;

            this.IsDataLoaded = true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}