using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Capstone
{
    public partial class Feed : ContentPage
    {
        public Feed()
        {
            InitializeComponent();
            BindingContext = new FeedViewModel();
        }

        private void AddPhoto_Clicked(object sender, System.EventArgs e)
        {
            // Navigate to a page where the user can add a new photo
        }
    }

    public class Photo
    {
        public string PhotoUrl { get; set; }
    }

    public class FeedViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Photo> Photos { get; set; }

        public FeedViewModel()
        {
            Photos = new ObservableCollection<Photo>
            {
                new Photo { PhotoUrl = "https://via.placeholder.com/150" },
                new Photo { PhotoUrl = "https://via.placeholder.com/150" },
                new Photo { PhotoUrl = "https://via.placeholder.com/150" }
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
