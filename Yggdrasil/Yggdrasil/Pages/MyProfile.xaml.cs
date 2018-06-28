using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Yggdrasil.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyProfile : ContentPage
    {
        public MyProfile()
        {
            InitializeComponent();
            ShowMyProfilePage();
        }

        public void ShowMyProfilePage()
        {
            var gridView = GetGridView();

            Content = new StackLayout()
            {
                BackgroundColor = Color.AliceBlue,
                Children =
                {
                    new Label()
                    {
                        Text = "My profile",
                        TextColor = Color.Black,
                        FontSize = 30,
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand,
                    },
                    gridView,
                    new Button
                    {
                        TextColor = Color.Black,
                        BackgroundColor = Color.DimGray,
                        Text = "Edit your profile",
                        Command = new Command(EditMyProfile)
                    },
                }
            };
        }

        public void EditMyProfile()
        {
            var nameLabel = new Label { Text = "Navn:"};
            var nameEntry = new Entry { HorizontalOptions = LayoutOptions.FillAndExpand};
            var birthdayLabel = new Label { Text = "Fødselsdag:"};
            var birthdayEntry = new Entry { Keyboard = Keyboard.Numeric, HorizontalOptions = LayoutOptions.FillAndExpand };
            var adressLabel = new Label { Text = "Adresse:"};
            var adressEntry = new Entry { HorizontalOptions = LayoutOptions.FillAndExpand };
            var phoneLabel = new Label { Text = "Telefonnummer:"};
            var phoneEntry = new Entry { Keyboard = Keyboard.Telephone, HorizontalOptions = LayoutOptions.FillAndExpand };
            var emailLabel = new Label { Text = "Epost:"};
            var emailEntry = new Entry {Keyboard = Keyboard.Email, HorizontalOptions = LayoutOptions.FillAndExpand };
            var extendedInfoLabel = new Label { Text = "Kort om deg selv:"};
            var extendedInfoEntry = new Entry { MaxLength = 140, VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.FillAndExpand };

            Content = new StackLayout
            {
                BackgroundColor = Color.AliceBlue,
                Children =
                {
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Children ={ nameLabel, nameEntry}
                    },
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Children ={ birthdayLabel, birthdayEntry}
                    },
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Children ={ adressLabel, adressEntry}
                    },
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Children ={ phoneLabel, phoneEntry}
                    },
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Children ={ emailLabel, emailEntry}
                    },
                    extendedInfoLabel, extendedInfoEntry
                }
            };
        }

        private static Grid GetGridView()
        {
            var gridView = new Grid { ColumnSpacing = 5, RowSpacing = 20 };
            gridView.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            gridView.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            gridView.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            gridView.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            var gridPicture = new BoxView { HorizontalOptions = LayoutOptions.StartAndExpand };
            var gridBasicInfo = new Label
            {
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                //Text = getBasicInfo()
            };
            var gridExtendedInfo = new Label
            {
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                //Text = getExtendedInfo()
            };

            gridView.Children.Add(gridPicture, 0, 0);
            gridView.Children.Add(gridBasicInfo, 1, 0);
            gridView.Children.Add(gridExtendedInfo, 0, 1);
            Grid.SetColumnSpan(gridExtendedInfo, 2);
            return gridView;
        }
    }
}