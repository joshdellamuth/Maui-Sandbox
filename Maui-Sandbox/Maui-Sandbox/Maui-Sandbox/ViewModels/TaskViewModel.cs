using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Maui_Sandbox.Models;

namespace Maui_Sandbox.ViewModel;

//MVVM can be implemented by implementing INotifyPropertyChanged
//when we implement the interface (right click when it is underlined red) 
//implementing the interface just means to include what is in the interface
//in this case, we implement INotifyPropertyChanged with the public event 
//line

public class TaskViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;

    // Call this method whenever the employee name is modified in the UI
    private void NotifyPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
