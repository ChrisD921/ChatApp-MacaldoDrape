using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using ChatApp.Models;
using ChatApp.ViewModel;
using Xamarin.Forms;

namespace ChatApp.Views
{
    public partial class ChatPage : ContentPage
    {
        public ChatPage()
        {
            InitializeComponent();
            BindingContext = new MyListViewModel();
        }
        void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            var _container = BindingContext as MyListViewModel;
            ChatListView.BeginRefresh();

            if (string.IsNullOrWhiteSpace(e.NewTextValue))
                ChatListView.ItemsSource = _container.MyListCollector;
            else
                ChatListView.ItemsSource = _container.MyListCollector.Where(i => i.MyName.Contains(e.NewTextValue));

            ChatListView.EndRefresh();
        }
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            var _container = BindingContext as MyListViewModel;
            //do work over here
            DisplayAlert("Great Success", "You now have a friend", "OK", "Cancel");
        }
    }
}