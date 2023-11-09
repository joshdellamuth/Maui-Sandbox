namespace Maui_Sandbox;

//This code initializes 
public partial class AppShell : Shell
{
    // contructor for AppShell that contains InitalizeComponent method and takes no parameters
    // because it is a constructor, Initialize component is ran when an instance of the class is created
    // therefore, something like AppShell appShell = new AppShell(); would call the method (also applies to other pages
    public AppShell()
	{
		InitializeComponent();
	}
}
