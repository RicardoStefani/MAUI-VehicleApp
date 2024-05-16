using VehicleAppBCA.Model;
using VehicleAppBCA.Services;

namespace VehicleAppBCA.Views;

[QueryProperty(nameof(VehicleId), "Id")]
public partial class VehiclePage : ContentPage
{
	private Vehicle vehicle = new Vehicle(){
		id = -1
	};
	private VehicleService vehicleService;

	public int VehicleId
	{
		set
		{
			this.vehicle = vehicleService.GetVehicle(value);
			entryMake.Text = this.vehicle.make;
			entryModel.Text = this.vehicle.model;
			entryEngineSize.Text = this.vehicle.engineSize;
			entryMileage.Text = this.vehicle.mileage.ToString();
			entryStartingBid.Text = this.vehicle.startingBid.ToString();
			checkBoxFavourite.IsChecked = this.vehicle.favourite;
		}
	}
	public VehiclePage()
	{
		vehicleService = VehicleService.Build();
		InitializeComponent();
	}

	public async void OnButtonSave(object sender, EventArgs e)
	{
		this.vehicle.make = entryMake.Text;
		this.vehicle.model = entryModel.Text;
		this.vehicle.engineSize = entryEngineSize.Text;
		this.vehicle.mileage = int.Parse(entryMileage.Text);
		this.vehicle.startingBid = int.Parse(entryStartingBid.Text);
		this.vehicle.favourite = checkBoxFavourite.IsChecked;
		
		this.vehicleService.SaveVehicle(vehicle);

        await Shell.Current.GoToAsync("..");
	}

	public async void OnButtonRemove(object sender, EventArgs e)
	{
		this.vehicleService.RemoveVehicle(vehicle.id);
		
        await Shell.Current.GoToAsync("..");
	}
}
