namespace ClassLibrary1
{
    public interface IVehicle
    {
        int Id { get; set; }
        string Make { get; set; }
        string Model { get; set; }
        void Drive();
        EngineBase Engine { get; set; }

    }
}