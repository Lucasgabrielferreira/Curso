namespace Modulo11;

public class TrabalhandoComDatas
{
    public void AulaDateTime()
    {   
        var date1 = new DateTime(2024, 02, 08, 12, 30, 30);
        var date2 = DateTime.Parse("2024/02/08 12:30:30");
        var date3 = DateTime.Now;
        var date4 = DateTime.Today;

        Console.WriteLine(date1);
        Console.WriteLine(date2);
        Console.WriteLine(date3);
        Console.WriteLine(date4);

        Console.WriteLine(date1.ToString("dd-MM-yyyy HH:mm:ss"));

        var dateOffset1 = new DateTimeOffset(DateTime.Now, new TimeSpan(-3, 0, 0));
        Console.WriteLine(dateOffset1.LocalDateTime);
        Console.WriteLine(dateOffset1.UtcDateTime);
    }
}