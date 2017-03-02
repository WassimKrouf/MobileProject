using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HDF.Models;
using Xamarin.Forms;

namespace HDF.ViewModels
{
    class MasterPageViewModel : ContentPage
    {
        public ListView ListView { get { return listView; } }
        ListView listView;

        public MasterPageViewModel()
        {
            var masterPageItems = new List<MasterPageItem>();
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Chercher partenaire",
                IconSource = " ",
                TargetType = typeof(SearchPartnerPageViewModel)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "s'inscrire",
                IconSource = " ",
                TargetType = typeof(InscriptionPageViewModel)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "A propos de HDF",
                IconSource = " ",
                TargetType = typeof(AboutPageViewModel)
            });

            listView = new ListView
            {
                ItemsSource = masterPageItems,
                ItemTemplate = new DataTemplate(() =>
                {
                    var imageCell = new ImageCell();
                    imageCell.SetBinding(TextCell.TextProperty, "Title");
                    imageCell.SetBinding(ImageCell.ImageSourceProperty, "IconSource");
                    return imageCell;
                }),
                VerticalOptions = LayoutOptions.FillAndExpand,
                SeparatorVisibility = SeparatorVisibility.None
            };

            Padding = new Thickness(0, 40, 0, 0);
            Icon = "hamburger.png";
            Title = "Personal Organiser";
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children = {
					listView
				}
            };
        }
    }
}
