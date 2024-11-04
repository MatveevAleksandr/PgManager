using System.Collections.ObjectModel;
using System.Reactive.Linq;
using ReactiveUI;
using System.Windows.Input;
using PgManager.Data.Core.Models;

namespace PgManager.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public Interaction<ServerConnectionAddViewModel, ServerConnection> ShowServerConnectionAdd { get; }
        public ICommand ServerConnectionAddCommand { get; }
        public ObservableCollection<ServerConnection> Servers { get; set; } = [];

        public MainWindowViewModel()
        {
            ShowServerConnectionAdd = new Interaction<ServerConnectionAddViewModel, ServerConnection>();
            ServerConnectionAddCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                var vm = new ServerConnectionAddViewModel();
                var result = await ShowServerConnectionAdd.Handle(vm);
                Servers.Add(result);
            });
        }
    }
}
