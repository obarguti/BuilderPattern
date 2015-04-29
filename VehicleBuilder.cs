namespace BuilderPattern
{
    public abstract class VehicleBuilder
    {
        protected Vehicle Vehicle;

        public Vehicle GetVehicle()
        {
            return Vehicle;
        }

        public void BuildVehicle()
        {
            Vehicle = new Vehicle();
        }

        public abstract void SetEngineSize();
        public abstract void SetTransmissionType();
        public abstract void SetAxelType();
        public abstract void SetIsConvertable();
        public abstract void SetOptions();
    }
}
