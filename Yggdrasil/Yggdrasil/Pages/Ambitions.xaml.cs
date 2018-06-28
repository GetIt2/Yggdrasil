using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Yggdrasil.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Ambitions : ContentPage
	{
		public Ambitions ()
		{
			InitializeComponent ();

		   // ViewAmbitionMainPage();
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