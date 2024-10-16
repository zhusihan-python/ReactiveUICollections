using ReactiveMvvm.ViewModels;
using ReactiveMvvm.Services;
using ReactiveMvvm.Views;
using ReactiveUI;
using Splat;

namespace ReactiveMvvm
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            // Register the custom view fetcher
            //Locator.CurrentMutable.Register(() => new FormViewFetcher(), typeof(IActivationForViewFetcher));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FeedbackView
            {
                ViewModel = new FeedbackViewModel(new WinFormsSender(), new Clock())
            });
        }
    }
}