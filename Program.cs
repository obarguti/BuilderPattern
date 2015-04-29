namespace BuilderPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            VehicleBuilder standardVehicleBuilder = new StandardVehicleBuilder();
            VehicleBuildManager vehicleBuildManager = new VehicleBuildManager(standardVehicleBuilder);
            vehicleBuildManager.BuildVehicle();
            
            Vehicle standardVehicle = standardVehicleBuilder.GetVehicle();

            VehicleBuilder luxuryVehicleBuilder = new LuxuryVehicleBuilder();
            vehicleBuildManager = new VehicleBuildManager(luxuryVehicleBuilder);
            vehicleBuildManager.BuildVehicle();

            Vehicle luxuryVehicle = luxuryVehicleBuilder.GetVehicle();
        }
    }
}
