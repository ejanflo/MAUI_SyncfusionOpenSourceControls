using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using FirstMAUIProject.Models;
using Contact = FirstMAUIProject.Models.Contact;

namespace FirstMAUIProject.ViewModels
{
    public class ContactViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private bool isLoading;
        public bool IsLoading
        {
            get => isLoading;
            set { isLoading = value; OnPropertyChanged(); }
        }

        private ObservableCollection<Contact> contacts;
        public ObservableCollection<Contact> Contacts
        {
            get => contacts;
            set { contacts = value; OnPropertyChanged(); }
        }

        public ContactViewModel() 
        {
            LoadDataAsync();
        }

        private async void LoadDataAsync()
        {
            IsLoading = true;

            // Simulate network delay
            await Task.Delay(8000);

            Contacts = new ObservableCollection<Contact>
        {
            new Contact { Name = "John Doe", Email = "john@example.com" },
            new Contact { Name = "Jane Smith", Email = "jane@example.com" },
            new Contact { Name = "Sam Wilson", Email = "sam@example.com" }
        };

            IsLoading = false;
        }

        private void OnPropertyChanged([CallerMemberName] string name = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        public class InverseBoolConverter : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
                => !(bool)value;

            public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
                => !(bool)value;
        }
    }
}
