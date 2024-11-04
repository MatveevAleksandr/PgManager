using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Avalonia;
using CommunityToolkit.Mvvm.Input;
using PgManager.Data.Core.Models;
using ReactiveUI;

namespace PgManager.ViewModels
{
    public class ServerConnectionAddViewModel : ViewModelBase
    {
        public string Host { get; set; } = string.Empty;
        public int Port { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public ServerConnectionAddViewModel()
        {
            OkCommand = ReactiveCommand.Create(() => new ServerConnection( Host, Port, UserName, Password ));
            CancelCommand = ReactiveCommand.Create(() => { });
        }

        public ReactiveCommand<Unit, ServerConnection> OkCommand { get; }
        public ReactiveCommand<Unit, Unit> CancelCommand { get; }
    }
}