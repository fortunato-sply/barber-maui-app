namespace Barber;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute("Menu", typeof(Menu));
		Routing.RegisterRoute("Login", typeof(Login));
	}
}

