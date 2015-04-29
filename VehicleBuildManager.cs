namespace BuilderPattern
{
    public class VehicleBuildManager
    {
        public VehicleBuilder VehicleBuilder { get; set; }

        public VehicleBuildManager(VehicleBuilder vehicleBuilder)
        {
            VehicleBuilder = vehicleBuilder;
        }

        public void BuildVehicle()
        {
            VehicleBuilder.BuildVehicle();
            VehicleBuilder.SetEngineSize();
            VehicleBuilder.SetTransmissionType();
            VehicleBuilder.SetAxelType();
            VehicleBuilder.SetIsConvertable();
            VehicleBuilder.SetOptions();
        }
    }
}
