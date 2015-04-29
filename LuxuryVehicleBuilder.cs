namespace BuilderPattern
{
    public class LuxuryVehicleBuilder : VehicleBuilder
    {
        public override void SetEngineSize()
        {
            Vehicle.EngineSize = 6.0;
        }

        public override void SetTransmissionType()
        {
            Vehicle.TransmissionType = TransmissionType.Automatic;
        }

        public override void SetAxelType()
        {
            Vehicle.AxelType = AxelType.FourWheel;
        }

        public override void SetIsConvertable()
        {
            Vehicle.IsConvertable = true;
        }

        public override void SetOptions()
        {
            Vehicle.Options = "AC, GPS, XM Radio, Leather Interior, Power Windows";
        }
    }
}
