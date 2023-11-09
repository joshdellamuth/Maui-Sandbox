﻿using Maui_Sandbox.ViewModel;

namespace Maui_Sandbox;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

		//Creates an instance of the class defined in the viewmodel and
		//uses it for the binding context (commented out for now)
		var mainPageViewModel = new MainPageViewModel()
		{
			TaskId = "3400",
			TaskName = "Feed Dog",
            TaskStatus = "Active",
            IsActive = true
        };

		BindingContext = mainPageViewModel;
	}
}

