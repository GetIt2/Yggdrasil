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
	            HorizontalOptions = LayoutOptions.Start,
	            Margin = 10,
	            Command = new Command(AddExperience)
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
	                addButton,
	                scrollingExperience
	            }
	        };
	        scrollingExperience.Content = GetExperiences();
	    }

	    private void AddExperience()
	    {
	        var header = new Label()
	        {
	            Text = "Add new experience",
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