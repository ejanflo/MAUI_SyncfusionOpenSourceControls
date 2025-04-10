using System.Collections.ObjectModel;

namespace FirstMAUIProject
{
    public class NavigationDrawerViewModel
    {
        public ObservableCollection<NavigationDrawer> Items { get; set; }

        public NavigationDrawerViewModel()
        {
            Items = new ObservableCollection<NavigationDrawer>
        {
            new NavigationDrawer { ImageSrc = "facebook.png", Description = "Profile" },
            new NavigationDrawer { ImageSrc = "google.png", Description = "Settings" },
            new NavigationDrawer { ImageSrc = "twitter.png", Description = "Item 4" },
            new NavigationDrawer { ImageSrc = "linkedin.png", Description = "Item 5" }
        };
        }
    }
}