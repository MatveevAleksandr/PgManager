using Avalonia.ReactiveUI;
using PgManager.ViewModels;
using ReactiveUI;
using System;
using System.Reactive;
using Avalonia.Controls;
using PgManager.Models;


namespace PgManager.Views;

public partial class ServerConnectionAddWindow : ReactiveWindow<ServerConnectionAddViewModel>
{
    public ServerConnectionAddWindow()
    {
        InitializeComponent();
        this.WhenActivated(action =>
        {
            action(ViewModel!.OkCommand.Subscribe(Close));
            action(ViewModel!.CancelCommand.Subscribe(Close));
        });

        
    }
}