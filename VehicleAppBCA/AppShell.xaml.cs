using VehicleAppBCA.Views;

namespace VehicleAppBCA;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(VehiclesPage), typeof(VehiclesPage));
        Routing.RegisterRoute(nameof(VehiclePage), typeof(VehiclePage));
    }
}

