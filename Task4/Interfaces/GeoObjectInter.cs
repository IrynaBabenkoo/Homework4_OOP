public interface GeoObjectInter
{
    double X { get; set; }
    double Y { get; set; }
    string Name { get; set; }
    string Description { get; set; }
    
    void GetInfo();
}