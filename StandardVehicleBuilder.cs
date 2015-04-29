namespace BuilderPattern
{
    public class StandardVehicleBuilder : VehicleBuilder
    {
        public override void SetEngineSize()
        {
            Vehicle.EngineSize = 1.8;
        }

        public override void SetTransmissionType()
        {
            Vehicle.TransmissionType = TransmissionType.Manual;
        }

        public override void SetAxelType()
        {
            Vehicle.AxelType = AxelType.FrontWheel;
        }

        public override void SetIsConvertable()
        {
            Vehicle.IsConvertable = false;
        }

        public override void SetOptions()
        {
            Vehicle.Options = "A/C, Radio";
        }
    }
}
