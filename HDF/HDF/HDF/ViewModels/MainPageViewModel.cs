using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HDF.Models;
using Xamarin.Forms;

namespace HDF.ViewModels
{
    public class MainPageViewModel : MasterDetailPage
    {
        private MasterPageViewModel _masterPage;
        public MainPageViewModel()
        {
            _masterPage = new MasterPageViewModel();
            Master = _masterPage;
            Detail = new NavigationPage(new LoginPageViewModel());

            _masterPage.ListView.ItemSelected += OnItemSelected;
        }
        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                _masterPage.ListView.SelectedItem = null;
                IsPresented = false;
            }
        }

    }
}
