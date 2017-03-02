using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HDF.Models;
using Xamarin.Forms;

namespace HDF.Views.Shared
{
    public partial class MasterPage : ContentPage
    {
        public ListView ListView { get { return listView; } }

        public MasterPage()
        {
            InitializeComponent();
            var masterPageItems = new List<MasterPageItem>();
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Contacts",
                IconSource = "contacts.png",
                TargetType = typeof(SearchPartnerPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "TodoList",
                IconSource = "todo.png",
                TargetType = typeof(InscriptionPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Reminders",
                IconSource = "reminders.png",
                TargetType = typeof(AboutPage)
            });

            listView.ItemsSource = masterPageItems;
        }
    }
}
