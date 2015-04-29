namespace BuilderPattern
{
    public class Vehicle
    {
        public double EngineSize { get; set; }
        public TransmissionType TransmissionType { get; set; }
        public AxelType AxelType { get; set; }
        public bool IsConvertable { get; set; }
        public string Options { get; set; }
    }

    public enum TransmissionType
    {
        Manual,
        Automatic
    }

    public enum AxelType
    {
        FrontWheel,
        RearWheel,
        FourWheel
    }
}
