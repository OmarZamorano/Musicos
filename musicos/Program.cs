abstract class Musico
{
    public string nombre{get; set;}
    public Musico(string n)
    {
        this.nombre=n;
    }
    public void Saluda()
    {
        Console.WriteLine("Hola soy "+nombre);
    }
    public /*virtual*/ abstract void Toca();
    //{
        //Console.WriteLine($"{nombre} tocando su instrumento");
    //}
}

class Cantante:Musico
{
    public string mic {get; set;}
    public Cantante(string n):base(n)
    {
        this.nombre=n;
    }
    public override void Toca()
    {
        Console.WriteLine(nombre+" esta cantando");
    }
}

class Bajista:Musico
{
    public string bajo{get; set;}
    public Bajista(string n, string b):base(n)
    {
        this.bajo=b;
    }
    public override void Toca()
    {
        Console.WriteLine($"{nombre} tocando su bajo");
    }
}
class Baterista:Musico
{
    public string bateria{get; set;}
    public Baterista(string n, string b):base(n)
    {
        this.bateria=b;
    }
    public override void Toca()
    {
        Console.WriteLine($"{nombre} tocando su bateria");
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        List<Musico> Beatles=new List<Musico>();
        Beatles.Add(new Cantante("Paul McCartney"));
        Beatles.Add(new Cantante("John Lennon"));
        Beatles.Add(new Bajista("George Harrison","Höfner"));
        Beatles.Add(new Baterista("Ringo Starr","LudWig"));

        foreach(var m in Beatles)
        {
           m.Saluda(); 
           m.Toca();
        }
    }
}
//los metodos abstractos no tienen implementacion
//se delegan de manera obligatoria