using PosColector.ViewModels;
using PosColector.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PosColector
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(CompraAbiertaPage),typeof(CompraAbiertaPage));
        }

    }
}
