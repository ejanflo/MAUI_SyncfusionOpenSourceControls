using FirstMAUIProject.Helpers;

namespace FirstMAUIProject
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            BindingContext = new NavigationDrawerViewModel();

            if (Settings.IsLoggedIn)
            {
                Navigation.PushAsync(new AppShell());
            }
            else
            {
                Navigation.PushAsync(new LoginPage());
            }

        }

        //private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    if (e.SelectedItem is Item selectedItem)
        //    {
        //        // Access the selected item
        //        string selectedDescription = selectedItem.Description;
        //        string navigateTo = selectedItem.NavigateTo;

        //        // Navigate if NavigateTo property is set
        //        if (!string.IsNullOrEmpty(navigateTo))
        //        {
        //            DisplayAlert("Title", $"Seleted {navigateTo}", "Okay");
        //        }

        //// Optionally, deselect the item to avoid keeping it highlighted
        ////((ListView)sender).SelectedItem = null;
        //    }
        //}
    }
}
