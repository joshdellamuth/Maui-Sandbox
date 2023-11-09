namespace Maui_Sandbox;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
