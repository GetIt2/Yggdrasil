using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Yggdrasil.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Experiences : ContentPage
	{
		public Experiences ()
		{
			InitializeComponent ();
		    ExperienceMain();
		}

	    private void ExperienceMain()
	    {
	        var header = new Label()
	        {
	            Text = "Experience",
	            FontSize = 50,
	            VerticalOptions = LayoutOptions.Start,
	            HorizontalOptions = LayoutOptions.CenterAndExpand,
	            Margin = 60
	        }; 
            var addButton = new Button()
	        {
	            Text = "Add new",
	            HorizontalOptions = LayoutOptions.StartAndExpand,
	            Margin = 10,
	            Command = new Command(AddExperience)
	        };
            var addDocumentation = new Button()
            {
                Text = "Document",
                HorizontalOptions = LayoutOptions.EndAndExpand,
                Margin = 10,
                Command = new Command(AddDocumentation)
            };
	        var anotherStack = new StackLayout()
	        {
	            Margin = 20,
	            Orientation = StackOrientation.Horizontal,
	            VerticalOptions = LayoutOptions.FillAndExpand,
	            Children =
	            {
	                addButton,
                    addDocumentation
	            }
	        };
            var scrollingExperience = new ScrollView()
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
                    anotherStack,
	                scrollingExperience
	            }
	        };
	        scrollingExperience.Content = GetExperiences();
	    }

	    private void AddDocumentation()
	    {
	        var header = new Label()
	        {
	            Text = "Document",
	            Margin = 60,
	            HorizontalOptions = LayoutOptions.CenterAndExpand,
	            FontSize = 31
	        };
	        var addButtonExp = new Button()
	        {
	            Text = "Experience to document",
	            Command = new Command(ExperienceMain),
	            BackgroundColor = Color.LightGray,
	            BorderColor = Color.Black,
            };
	        var addDocumentation = new Button()
	        {
	            Text = "Add Documentation",
	            Command = new Command(AddDocumentations),
	            BackgroundColor = Color.LightGray,
	            BorderColor = Color.Black,
            };
            var addFields = new StackLayout()
	        {
	            Margin = 20,
	            VerticalOptions = LayoutOptions.FillAndExpand,
	            Children =
	            {
	                
	            }
	        };
	        Content = new StackLayout()
	        {
	            HorizontalOptions = LayoutOptions.Center,
                Children =
	            {
	                header,
	                addButtonExp,
	                addDocumentation,
	                addFields,
                }

	        };
        }

	    private void AddDocumentations()
	    {
	        var header = new Label()
	        {
	            Text = "Document",
	            Margin = 60,
	            HorizontalOptions = LayoutOptions.CenterAndExpand,
	            FontSize = 31
	        };
	        var goBack = new Button()
	        {
	            Text = "Back",
	            Command = new Command(AddDocumentation),
                BackgroundColor = Color.LightGray,
                BorderColor = Color.Black,
	        };
	        var addPicture = new Button()
	        {
	            Text = "Picture",
	            Command = new Command(AddDocumentation),
	            BackgroundColor = Color.LightGray,
	            BorderColor = Color.Black,
            };
	        var addVideo = new Button()
	        {
	            Text = "Video",
	            Command = new Command(AddDocumentation),
	            BackgroundColor = Color.LightGray,
	            BorderColor = Color.Black,
            };
	        var addRef = new Button()
	        {
	            Text = "Reference",
	            Command = new Command(AddDocumentation),
	            BackgroundColor = Color.LightGray,
	            BorderColor = Color.Black,
            };
	        var addLinks = new Button()
	        {
	            Text = "Links",
	            Command = new Command(AddDocumentation),
	            BackgroundColor = Color.LightGray,
	            BorderColor = Color.Black,
            };
	        var addDiplomas = new Button()
	        {
	            Text = "Diplomas",
	            Command = new Command(AddDocumentation),
	            BackgroundColor = Color.LightGray,
	            BorderColor = Color.Black,
            };
            Content = new StackLayout()
	        {
                HorizontalOptions = LayoutOptions.Center,
	            Children =
	            {
	                header,
	                addPicture,
	                addVideo,
	                addRef,
	                addLinks,
	                addDiplomas,
                    goBack
                }
	        };
        }

        private void AddExperience()
	    {
	        var header = new Label()
	        {
	            Text = "Add new experiences",
	            Margin = 60,
	            HorizontalOptions = LayoutOptions.CenterAndExpand,
	            FontSize = 31
	        };
	        var experienceEntry = new Entry()
	        {
	            Placeholder = "Experience"
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
	            Command = new Command(ExperienceMain)
	        };
	        var addFields = new StackLayout()
	        {
	            Margin = 20,
	            HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.FillAndExpand,
	            Children =
	            {
	                experienceEntry,
	                descriptionLabel,
	                descriptionField
	            }
	        };
	        Content = new StackLayout()
	        {
	            HorizontalOptions = LayoutOptions.Center,
                Children =
	            {
	                header,
	                addFields,
	                addButton
	            }
	        };
	    }

	    private StackLayout GetExperiences()
	    {
	        var Experience = new StackLayout();
	        var numberOfExperience = 100;

	        for (int i = 0; i < numberOfExperience; i++)
	        {
	            var view = new ContentView()
	            {
	                BackgroundColor = i % 2 == 0 ? Color.Gray : Color.DimGray,
	                HorizontalOptions = LayoutOptions.FillAndExpand,
	                Padding = 10,
	                Margin = 2
	            };
	            var experience = new Label
	            {
	                Text = $"Experience {i}",
	                TextColor = Color.White
	            };
	            view.Content = experience;
	            Experience.Children.Add(view);
	        }

	        return Experience;
	    }

    }
}