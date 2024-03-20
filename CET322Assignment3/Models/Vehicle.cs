namespace CET322Assignment3.Models;

public class Vehicle
{
    public int Id { get; set; }
    public string CarPlate { get; set; }
    public double Km { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public string GearType { get; set; }
    public int BrandId { get; set; }
    public Brand Brand { get; set; }
}