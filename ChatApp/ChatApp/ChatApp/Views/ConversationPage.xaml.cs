using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using ChatApp.ViewModels;
using Xamarin.Forms;

namespace ChatApp.Views
{
    public partial class ConversationPage : ContentPage
    {
        public ConversationPage()
        {
            InitializeComponent();
            this.BindingContext = new ConvoPageViewModel();
        }

        public void ScrollTap(object sender, System.EventArgs e)
        {
            lock (new object())
            {
                if (BindingContext != null)
                {
                    var vm = BindingContext as ConvoPageViewModel;

                    Device.BeginInvokeOnMainThread(() =>
                    {
                        while (vm.DelayedMessages.Count > 0)
                        {
                            vm.Messages.Insert(0, vm.DelayedMessages.Dequeue());
                        }
                        vm.ShowScrollTap = false;
                        vm.LastMessageVisible = true;
                        vm.PendingMessageCount = 0;
                        ChatList?.ScrollToFirst();
                    });


                }

            }
        }

        public void OnListTapped(object sender, ItemTappedEventArgs e)
        {
            chatInput.UnFocusEntry();
        }
    }
}