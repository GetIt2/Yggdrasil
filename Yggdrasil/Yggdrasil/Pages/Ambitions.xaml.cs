using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Yggdrasil.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ambitions : ContentPage
    {
        public Ambitions()
        {
            InitializeComponent();

            ViewAmbitionMainPage();
        }

        private void ViewAmbitionMainPage()
        {
            var header = new Label()
            {
                Text = "Ambitions",
                FontSize = 50,
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Margin = 60
            };
            var addButton = new Button()
            {
                Text = "Add new",
                HorizontalOptions = LayoutOptions.Start,
                Margin = 10,
                Command = new Command(AddAmbition)
            };
            var scrollingAmbitions = new ScrollView()
            {
                BackgroundColor = Color.DarkGray,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Margin = 10
            };
            Content = new StackLayout()
            {
                Children =
                {
                    header,
                    addButton,
                    scrollingAmbitions
                }
            };
            scrollingAmbitions.Content = GetAmbitions();
        }

        private void AddAmbition()
        {
            var header = new Label()
            {
                Text = "Add new ambition",
                Margin = 60,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                FontSize = 31
            };
            var ambitionEntry = new Entry()
            {
                Placeholder = "Ambition"
            };
            var descriptionLabel = new Label()
            {
                Text = "Description:",
                Margin = 4,
                FontSize = 17
            };
            var descriptionField = new Editor()
            {
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            var addButton = new Button()
            {
                Text = "Add",
                Command = new Command(ViewAmbitionMainPage)
            };
            var addFields = new StackLayout()
            {
                Margin = 20,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children =
                {
                    ambitionEntry,
                    descriptionLabel,
                    descriptionField
                }
            };
            Content = new StackLayout()
            {
                Children =
                {
                    header,
                    addFields,
                    addButton
                }
            };
        }

        private StackLayout GetAmbitions()
        {
            var ambitions = new StackLayout();
            var numberOfAmbitions = 100;

            for (int i = 0; i < numberOfAmbitions; i++)
            {
                var view = new ContentView()
                {
                    BackgroundColor = i % 2 == 0 ? Color.Gray : Color.DimGray,
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    Padding = 10,
                    Margin = 2
                };
                var ambition = new Label
                {
                    Text = $"Ambition {i}",
                    TextColor = Color.White
                };
                view.Content = ambition;
                ambitions.Children.Add(view);
            }

            return ambitions;
        }
    }
}