namespace MS_Build_MobileDesktop_Apps;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
