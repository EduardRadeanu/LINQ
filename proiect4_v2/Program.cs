public class Car
{
    public int Id;
    public string Brand;
    public string Model;
    public bool IsElectric;
    public int MaxSpeedKmh;
    public int AutonomyKm;
}
public class CarRepository
{
    public static List<Car> GetAll()
    {
        return new List<Car>
        {
            new Car { Id = 1, Brand = "Dacia", Model = "Spring", IsElectric = true, AutonomyKm = 300, MaxSpeedKmh = 120 },
            new Car { Id = 2, Brand = "VW", Model = "Polo", IsElectric = false, AutonomyKm = 850, MaxSpeedKmh = 180 },
            new Car { Id = 3, Brand = "Ford", Model = "Focus", IsElectric = false, AutonomyKm = 950, MaxSpeedKmh = 210 },
            new Car { Id = 4, Brand = "Tesla", Model = "Model 3", IsElectric = true, AutonomyKm = 500, MaxSpeedKmh = 260 },
            new Car { Id = 5, Brand = "Opel", Model = "Astra", IsElectric = false, AutonomyKm = 1010, MaxSpeedKmh = 190 }
        };
    }
}
public class CarService
{
    private CarRepository carRepository;
    List<Car> cars = CarRepository.GetAll();

    public List<Car> GetHighSpeedCars()
    {
        return cars.Where(car => car.MaxSpeedKmh > 180).ToList();
    }
    public List<Car> GetAutonomyCars()
    {
        return cars.Where(car => car.AutonomyKm > 180).ToList();
    }
    public int NumarMasini()
    {
        return cars.Count(car => car.MaxSpeedKmh >= 100 && car.MaxSpeedKmh <= 200);
    }
}