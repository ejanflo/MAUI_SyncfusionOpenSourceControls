namespace FirstMAUIProject
{
    public partial class MainPage : ContentPage
    {
        //SfTabView tabView;

        public MainPage()
        {
            InitializeComponent();
            //var tabView = new SfTabView();
            //Grid allContactsGrid = new Grid { BackgroundColor = Colors.Red };
            //var favorites = new ListView
            //{
            //    RowHeight = 50,
            //    ItemsSource = new string[] { "James", "Richard", "Michael", "Alex", "Clara" },
            //    ItemTemplate = new DataTemplate(() =>
            //    {
            //        var grid = new Grid
            //        {
            //            Margin = new Thickness(10, 5)
            //        };

            //        var label = new Label
            //        {
            //            VerticalOptions = LayoutOptions.Start,
            //            HorizontalOptions = LayoutOptions.Start,
            //            TextColor = Color.FromArgb("#666666"),
            //            FontSize = 16
            //        };
            //        label.SetBinding(Label.TextProperty, ".");

            //        grid.Children.Add(label);

            //        return new ViewCell
            //        {
            //            View = grid
            //        };
            //    })
            //};
            //Grid contactsGrid = new Grid { BackgroundColor = Colors.Blue };
            //var tabItems = new TabItemCollection
            //{
            //    new SfTabItem()
            //    {
            //        Header = "Call",
            //        Content = allContactsGrid
            //    },
            //    new SfTabItem()
            //    {
            //        Header = "Favorites",
            //        Content = favorites
            //    },
            //    new SfTabItem()
            //    {
            //        Header = "Contacts",
            //        Content = contactsGrid
            //    }
            //};

            //tabView.Items = tabItems;
            //this.Content = tabView;
        }
    }

}
