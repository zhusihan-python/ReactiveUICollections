namespace Demo.ReactiveUI.Winforms.Routing.ViewModels
{
    using global::ReactiveUI;
    using System;
    using System.Reactive;
    using System.Reactive.Linq;

    public class ShellViewModel : ReactiveObject, IScreen
    {
        #region Fields

        private string _applicationTitle;

        #endregion Fields

        #region Constructors

        public ShellViewModel()
        {
            // 初始化路由
            Router = new RoutingState();
            // 初始化属性
            ApplicationTitle = "ReactiveUI Winforms Demo - Routing";
            // 初始化命令
            ShowHomeCommand = ReactiveCommand.Create(ShowHome);
            ShowHomeCommand.Subscribe(_ => ShowHome());
            ShowAboutCommand = ReactiveCommand.Create(ShowAbout);
            ShowAboutCommand.Subscribe(_ => ShowAbout());
            ShowContactCommand = ReactiveCommand.Create(ShowContact);
            ShowContactCommand.Subscribe(_ => ShowContact());
            GoBackCommand = ReactiveCommand.CreateFromObservable<Unit, Unit>(_ => Observable.Return(Unit.Default),Router.NavigateBack.CanExecute);
            GoBackCommand.Subscribe(_ => GoBack());

            Router.NavigateAndReset.Execute(new HomeViewModel());
        }

        #endregion Constructors

        #region Properties

        public string ApplicationTitle
        {
            get => _applicationTitle;
            set => this.RaiseAndSetIfChanged(ref _applicationTitle, value);
        }

        public ReactiveCommand<Unit, Unit> GoBackCommand
        {
            get;
        }

        public RoutingState Router
        {
            get;
        }

        public ReactiveCommand<Unit, Unit> ShowAboutCommand
        {
            get;
        }

        public ReactiveCommand<Unit, Unit> ShowContactCommand
        {
            get;
        }

        public ReactiveCommand<Unit, Unit> ShowHomeCommand
        {
            get;
        }

        #endregion Properties

        #region Methods

        private void GoBack()
        {
            if (Router.NavigationStack.Count > 0)
            {
                Router.NavigateBack.Execute();
            }
        }

        private void ShowAbout()
        {
            // 导航到AboutViewModel
            Router.Navigate.Execute(new AboutViewModel());
        }

        private void ShowContact()
        {
            // 导航到ContactViewModel
            Router.Navigate.Execute(new ContactViewModel());
        }

        private void ShowHome()
        {
            // 导航到HomeViewModel
            Router.Navigate.Execute(new HomeViewModel());
        }

        #endregion Methods
    }
}