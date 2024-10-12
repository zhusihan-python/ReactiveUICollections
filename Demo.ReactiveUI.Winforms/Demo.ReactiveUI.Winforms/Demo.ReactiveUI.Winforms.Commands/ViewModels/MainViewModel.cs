namespace Demo.ReactiveUI.Winforms.Commands.ViewModels
{
    using global::ReactiveUI;
    using System;
    using System.Reactive;
    using System.Reactive.Linq;
    using System.Windows;
    //using System.Windows.Forms;

    public class MainViewModel : ReactiveObject
    {
        #region Fields

        private string _applicationTitle;
        private string _withCanExecuteParameter;

        #endregion Fields

        #region Constructors

        public MainViewModel()
        {
            // 设置属性
            ApplicationTitle = "ReactiveUI Winforms Demo - Commands";

            // 创建无参数命令
            ParameterlessCommand = ReactiveCommand.Create(() => Parameterless());
            ParameterlessCommand.Subscribe(_ => Parameterless());

            // 使用参数创建命令
            WithParameterCommand = ReactiveCommand.Create<string>(WithParameter);

            // 带判断执行创建命令
            WithCanExecuteCommand = ReactiveCommand.Create<string>(WithCanExecute,
                                    this.WhenAnyValue(vm => vm.WithCanExecuteParameter).Select(s => string.IsNullOrEmpty(s) == false));
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// 标题
        /// </summary>
        public string ApplicationTitle
        {
            get => _applicationTitle;
            set => this.RaiseAndSetIfChanged(ref _applicationTitle, value);
        }

        /// <summary>
        /// 无参数命令
        /// </summary>
        public ReactiveCommand<Unit, Unit> ParameterlessCommand
        {
            get;
        }

        /// <summary>
        /// 带参数可执行命令
        /// </summary>
        public ReactiveCommand<string, Unit> WithCanExecuteCommand
        {
            get;
        }

        public string WithCanExecuteParameter
        {
            get => _withCanExecuteParameter;
            set => this.RaiseAndSetIfChanged(ref _withCanExecuteParameter, value);
        }

        /// <summary>
        /// 带参数命令
        /// </summary>
        public ReactiveCommand<string, Unit> WithParameterCommand
        {
            get;
        }

        #endregion Properties

        #region Methods

        private void Parameterless()
        {
            System.Windows.MessageBox.Show("You pressed the button!", ApplicationTitle, MessageBoxButton.OK);
        }

        private void WithCanExecute(string parameter)
        {
            System.Windows.MessageBox.Show(WithCanExecuteParameter, ApplicationTitle, MessageBoxButton.OK);
        }

        private void WithParameter(string message)
        {
            System.Windows.MessageBox.Show(message.ToString(), ApplicationTitle, MessageBoxButton.OK);
        }

        #endregion Methods
    }
}