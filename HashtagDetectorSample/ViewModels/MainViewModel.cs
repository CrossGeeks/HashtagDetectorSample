using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Acr.UserDialogs;
using Xamarin.Forms;

namespace HashtagDetectorSample.ViewModels
{
    public class MainViewModel
    {
        public string Text { get; set; } = "Welcome to Xamarin.Forms! #crossgeeks #xamboy #hashtagsample";
        public ICommand HashtagCommand { get; set; }

        public MainViewModel()
        {
            HashtagCommand = new Command<string>(OnHashtag);
        }

        async void OnHashtag(string hashTag)
        {
           await UserDialogs.Instance.AlertAsync("Hashtag tapped",hashTag,"Ok");
        }
    }
}
