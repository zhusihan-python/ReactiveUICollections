using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;

using ReactiveUI;


/// <summary>
/// ViewModel Example
/// </summary>
namespace WinFormRxUI.ViewModels
{
    public class HomeViewModel : ReactiveUI.ReactiveObject
    {
        string modelString = "";
        public string EnteredText
        {
            get { return modelString; }
            set { this.RaiseAndSetIfChanged(ref modelString, value); }
        }

        string statusString = "";
        public string Status
        {
            get { return statusString; }
            set { this.RaiseAndSetIfChanged(ref statusString, value); }
        }

        public ReactiveCommand<Unit, Unit> OKCmd { get; private set; }

        public HomeViewModel()
        {
            OKCmd = ReactiveCommand.Create(() => { Status = EnteredText + " is saved."; }
                , this.WhenAnyValue(vm => vm.EnteredText, s => !string.IsNullOrWhiteSpace(s)));
        }
    }
}
