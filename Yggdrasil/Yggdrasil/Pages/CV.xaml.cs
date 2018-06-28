using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Yggdrasil.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CV : ContentPage
	{
		public CV ()
		{
			InitializeComponent ();
            CVPage();
		}
        
	    private void CVPage()
	    {
	        var picture = new Image()
	        {
                VerticalOptions = LayoutOptions.FillAndExpand,
	            Source = ImageSource.FromResource("Yggdrasil.Images.cv-example.jpg")
            };
	        Content = new StackLayout()
	        {
	            HorizontalOptions = LayoutOptions.Center,
	            Children =
	            {
	                picture
	            }

	        };
        }
	}
}