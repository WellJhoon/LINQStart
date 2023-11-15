

var Romos = new List<Romo>()
{
    new Romo(){Name = "Presidente", Brand = "Presidete", Alchol = 7.2m},
    new Romo(){Name = "Vodka", Brand = "Ruso", Alchol = 50m},
    new Romo(){Name = "Extra Viejo", Brand = "Brugal", Alchol = 25m},
    new Romo(){Name = "Kleren", Brand = "Patio Doña juana", Alchol = 95.5m}
};

//Colecciones anonimas con LINQ
var Romos2 = from b in Romos
             select new { b.Name, b.Brand };

foreach (var b in Romos2)
{
    Console.WriteLine(b.Brand);
}
public class Romo
{
    public string? Name { get; set; }
    public string? Brand { get; set; }
    public decimal Alchol { get; set; }
}