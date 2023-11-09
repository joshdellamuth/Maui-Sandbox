using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.ComponentModel;

namespace Maui_Sandbox.ViewModel;

//MVVM can be implemented by implementing INotifyPropertyChanged
//when we implement the interface (right click when it is underlined red) 
//implementing the interface just means to include what is in the interface
//in this case, we implement INotifyPropertyChanged with the public event 
//line
public partial class MainPageViewModel : INotifyPropertyChanged
{
    public string TaskId { get; set; }
    public string TaskName { get; set; }
    public string TaskStatus { get; set; }
    public bool IsActive { get; set; }

    public event PropertyChangedEventHandler PropertyChanged;
}
