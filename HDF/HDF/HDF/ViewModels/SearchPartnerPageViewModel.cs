using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HDF.ViewModels
{
    public class SearchPartnerPageViewModel : ContentPage
    {
        public SearchPartnerPageViewModel()
        {
            Title = "recherche partenaire";
            Content = new StackLayout
            {
                Children = {
					new Label {
						Text = "recherche data goes here",
						HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.CenterAndExpand
					}
				}
            };
        }
    }
}
