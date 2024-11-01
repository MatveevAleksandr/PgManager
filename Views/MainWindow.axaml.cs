using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.ReactiveUI;
using PgManager.Models;
using PgManager.ViewModels;
using ReactiveUI;

namespace PgManager.Views
{
    public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
    {
        public MainWindow()
        {
            InitializeComponent();

            this.WhenActivated(action => action(ViewModel!.ShowServerConnectionAdd.RegisterHandler(ShowServerConnectionAdd)));
        }

        private async Task ShowServerConnectionAdd (InteractionContext<ServerConnectionAddViewModel, ServerConnection> context)
        {
            var window = new ServerConnectionAddWindow
            {
                DataContext = context.Input
            };

            var result = await window.ShowDialog<ServerConnection>(this);
            context.SetOutput(result);
        }
    }
}