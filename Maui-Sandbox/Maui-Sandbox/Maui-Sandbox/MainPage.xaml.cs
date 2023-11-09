using Maui_Sandbox.ViewModel;

namespace Maui_Sandbox;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

        //Creates an instance of the class defined in the viewmodel and
        //uses it for the binding context (commented out for now)
        //var mainPageViewModel = new MainPageViewModel()
        //{
        //	TaskId = "3400",
        //	TaskName = "Feed Dog",
        //          TaskStatus = "Active",
        //          IsActive = true
        //      };

        //BindingContext = mainPageViewModel;
        
    }
    private void TaskButton1_Clicked(object sender, EventArgs e)
    {
        var mainPageViewModel = new MainPageViewModel()
        {
            TaskId = "3401",
            TaskName = "Feed Dog",
            TaskStatus = "Active",
            IsActive = true
        };
        var mVVMDemo = new MVVMDemo();
        mVVMDemo.BindingContext = mainPageViewModel;
        Navigation.PushAsync(mVVMDemo);
    }
    private void TaskButton2_Clicked(object sender, EventArgs e)
    {
        var mainPageViewModel = new MainPageViewModel()
        {
            TaskId = "3402",
            TaskName = "Ride Bike",
            TaskStatus = "Active",
            IsActive = true
        };
        var mVVMDemo = new MVVMDemo();
        mVVMDemo.BindingContext = mainPageViewModel;
        Navigation.PushAsync(mVVMDemo);
    }

    private void TaskButton3_Clicked(object sender, EventArgs e)
    {
        var mainPageViewModel = new MainPageViewModel()
        {
            TaskId = "3403",
            TaskName = "Make Lunch",
            TaskStatus = "Pending",
            IsActive = false
        };
        var mVVMDemo = new MVVMDemo();
        mVVMDemo.BindingContext = mainPageViewModel;
        Navigation.PushAsync(mVVMDemo);
    }
}

