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
            var extendedInfoEditor = new Editor { MaxLength = 140, VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.FillAndExpand };

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
                    extendedInfoLabel, extendedInfoEditor,
                    new Button(){Text = "Save", Command = new Command(ShowMyProfilePage)}
                }
            };
        }

        private static Grid GetGridView()
        {
            var gridView = new Grid { ColumnSpacing = 5, RowSpacing = 20, VerticalOptions = LayoutOptions.FillAndExpand};
            gridView.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });
            gridView.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            gridView.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            gridView.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            var gridPicture = new BoxView { HorizontalOptions = LayoutOptions.StartAndExpand };
            var gridBasicInfo = new Label
            {
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Text = GetBasicInfo()
            };
            var gridExtendedInfo = new Label
            {
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Text = GetExtendedInfo()
            };

            gridView.Children.Add(gridPicture, 0, 0);
            gridView.Children.Add(gridBasicInfo, 1, 0);
            gridView.Children.Add(gridExtendedInfo, 0, 1);
            Grid.SetColumnSpan(gridExtendedInfo, 2);
            return gridView;
        }

        private static string GetBasicInfo()
        {
            var text = "Navn: Ola Nordman" +
                       "Fødselsdag: 01.01.1970" +
                       "Adressa: Startgata 1 0001 Oslo" +
                       "Telefon nummer: 12345678" +
                       "Epost: ola.nordmann@example.com";
            return text;

        }

        private static string GetExtendedInfo()
        {
            var text =
                "Jeg er en mann på 48, ugift og kommer opprinnelig fra landet, men har flyttet til Oslo for å studere. Jeg har nå fullført mine studier. Utdannelsen min inneholder elementer som salg og kundebehandling, samt en del markedsføring." +
                "De som kjenner meg vil sannsynligvis si at jeg er svært målbevisst, selvstendig, og initiativrik.I tillegg når jeg som regel de mål jeg har satt meg, og er født med godt humør og har positiv innstilling.";
            return text;
        }
    }
}