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
using PgManager.Models;
using ReactiveUI;

namespace PgManager.ViewModels
{
    public class ServerConnectionAddViewModel : ViewModelBase
    {
        public string ServerName { get; set; } = string.Empty;

        public ServerConnectionAddViewModel()
        {
            OkCommand = ReactiveCommand.Create(() => new ServerConnection() { ServerName = ServerName });
            CancelCommand = ReactiveCommand.Create(execute: () => {  });
        }

        public ReactiveCommand<Unit, ServerConnection> OkCommand { get; }
        public ReactiveCommand<Unit, ServerConnection> CancelCommand { get; }
    }
}