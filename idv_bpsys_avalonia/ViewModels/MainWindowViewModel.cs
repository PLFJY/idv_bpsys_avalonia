using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Styling;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FluentAvalonia.UI.Controls;
using FluentAvalonia.UI.Windowing;
using Tmds.DBus.Protocol;
using idv_bpsys_avalonia.Helpers;
using SymbolIconSource = FluentIcons.Avalonia.Fluent.SymbolIconSource;
using Symbol = FluentIcons.Common.Symbol;

namespace idv_bpsys_avalonia.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    private string _currentSurTeamName;
    public string CurrentSurTeamName {
        get => StaticData.CurrentSurTeam.Name;
        set
        {
            _currentSurTeamName = value;
            OnPropertyChanged();
        }
    }
        
    private string _currentHunTeamName;
    public string CurrentHunTeamName {
        get => StaticData.CurrentHunTeam.Name;
        set
        {
            _currentHunTeamName = value;
            OnPropertyChanged();
        }
    }
    
    [RelayCommand]
    private void ThemeChange()
    {
        App.AppBase.ChangeTheme();
    }

    [RelayCommand]
    private void Swap()
    {
        (StaticData.CurrentSurTeam, StaticData.CurrentHunTeam) = (StaticData.CurrentHunTeam, StaticData.CurrentSurTeam);
        OnPropertyChanged(nameof(CurrentSurTeamName));
        OnPropertyChanged(nameof(CurrentHunTeamName));
    }

    [ObservableProperty] private List<string> _gameList =
    [
        "Free",
        "Game 1 First Half",
        "Game 1 Second Half",
        "Game 2 First Half",
        "Game 2 Second Half",
        "Game 3 First Half",
        "Game 3 Second Half",
        "Game 3 Extra First Half",
        "Game 3 Extra Second Half",
        "Game 4 First Half",
        "Game 4 Second Half",
        "Game 5 First Half",
        "Game 5 Second Half",
        "Game 5 Extra First Half",
        "Game 5 Extra Second Half"
    ];

    [ObservableProperty] private List<string> _timerList =
    [
        "30",
        "45",
        "60",
        "90",
        "120",
        "150",
        "180",
    ];

    [ObservableProperty] private ObservableCollection<NavigationViewItem> _menuItems =
    [
        new NavigationViewItem()
        {
            Content = "启动页",
            IconSource = new SymbolIconSource() { Symbol = Symbol.Home }
        },
        new NavigationViewItem()
        {
        Content = "队伍信息",
        IconSource = new SymbolIconSource() { Symbol = Symbol.People }
        },
        new NavigationViewItem()
        {
            Content = "地图BP",
            IconSource = new SymbolIconSource() { Symbol = Symbol.Map }
        },
        new NavigationViewItem()
        {
            Content = "Ban监管",
            IconSource = new SymbolIconSource() { Symbol = Symbol.PresenterOff }
        },
        new NavigationViewItem()
        {
            Content = "Ban求生",
            IconSource = new SymbolIconSource() { Symbol = Symbol.PersonProhibited }
        },
        new NavigationViewItem()
        {
            Content = "角色选择",
            IconSource = new SymbolIconSource() { Symbol = Symbol.PersonAdd }
        },
        new NavigationViewItem()
        {
            Content = "天赋特质",
            IconSource = new SymbolIconSource() { Symbol = Symbol.PersonWalking }
        },
        new NavigationViewItem()
        {
            Content = "比分控制",
            IconSource = new SymbolIconSource() { Symbol = Symbol.NumberRow }
        },
        new NavigationViewItem()
        {
            Content = "赛后数据",
            IconSource = new SymbolIconSource() { Symbol = Symbol.TextBulletListSquare }
        },
        new NavigationViewItem()
        {
            Content = "启动前台",
            IconSource = new SymbolIconSource() { Symbol = Symbol.ShareScreenStart },
            
        },
        new NavigationViewItem()
        {
            Content = "设置",
            IconSource = new SymbolIconSource() { Symbol = Symbol.Settings }
        },
        new NavigationViewItem()
        {
            Content = "其它",
            IconSource = new SymbolIconSource() { Symbol = Symbol.Info }
        }
    ];
    
} 