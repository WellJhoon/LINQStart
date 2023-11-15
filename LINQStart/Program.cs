

var Romos = new List<Romo>()
{
    new Romo(){Name = "Presidente", Brand = "Presidete", Alchol = 7.2m},
    new Romo(){Name = "Vodka", Brand = "Ruso", Alchol = 50m},
    new Romo(){Name = "Extra Viejo", Brand = "Brugal", Alchol = 25m},
    new Romo(){Name = "Kleren", Brand = "Patio Doña juana", Alchol = 95.5m}
};

var Brands = new List<Brand>()
{
    new Brand(){Name = "Erdiger", Country = "Alemania"},
    new Brand(){Name = "Modelo", Country = "Mexico"},
    new Brand(){Name = "Presidente", Country = "RD"},
    new Brand(){Name = "NoTiene", Country = "PR"},
    new Brand(){Name = "Republica", Country = "RD"}
};

//Select LINQ
var Romos2 = from b in Romos
             select new { b.Name, b.Brand };



// Where Query Expression
var Romos3 = from b in Romos
             where b.Brand == "Brugal" || b.Alchol >= 10
             select new { b.Name, b.Brand };


//Metodos
var Romos4 = Romos.Where(b => b.Brand == "Brugal" || b.Alchol >= 10)
                    .Select(b => new
                    { b.Name, b.Brand });



//ORDER BY
var Romos5 = from b in Romos
             where b.Brand == "Brugal" || b.Alchol >= 10
             orderby b.Name //desending == Sirve para que esten ordenados desde atras hacia adelante z > a
             select new { b.Name, b.Brand };

//GROUP BY
var Romos6 = from b in Romos
             group b by b.Brand into groupRomos
             select new
             {
                 brand = groupRomos.Key,
                 count = groupRomos.Count(),
             };


//Join
var Romos7 = from b in Romos
             join bra in Brands on b.Brand equals bra.Name
             select new
             {
                 Name = b.Name,
                 Brand = b.Brand,
                 Country = bra.Country
             };




foreach (var b in Romos7)
{
    Console.WriteLine(b.Name + " "+ b.Brand + " " + b.Country);
}


/*
foreach (var b in Romos5)
{
    Console.WriteLine(b.Name);
}
*/


public class Romo
{
    public string? Name { get; set; }
    public string? Brand { get; set; }
    public decimal Alchol { get; set; }
}


public class Brand
{
    public string? Name { get; set; }
    public string? Country { get; set; }
}