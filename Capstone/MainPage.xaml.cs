using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace Capstone
{

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();

        }
    }

    public class MainPageViewModel
    {
        public ObservableCollection<Message> Messages { get; } = new ObservableCollection<Message>();

        public ICommand SendMessageCommand { get; }

        public ICommand NavigateToLoginCommand { get; }

        public MainPageViewModel()
        {
            SendMessageCommand = new Command(() =>
            {
                try
                {
                    var messageText = ((MainPage)Application.Current.MainPage).MessageEntry.Text;
                    Messages.Add(new Message { Text = messageText, TimeStamp = DateTime.Now });
                    ((MainPage)Application.Current.MainPage).MessageEntry.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    // Log the exception or display an error message to the user
                }
            });

            NavigateToLoginCommand = new Command(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(new LoginPage());
            });
        }
    }


    public class Message
    {
        public string Text { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
