namespace GalaxyToolApi.Interfaces
{
    public interface ICoordinateContainer
    {
        int Galaxy { get; set; }
        int System { get; set; }
        int Planet { get; set; }
    }
}