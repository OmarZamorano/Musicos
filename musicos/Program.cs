abstract class Musico
{
    public string nombre{get; set;}
    public Musico(string n)
    {
        this.nombre=n;
    }
    public virtual string setSaluda()
    {
        return "Hola soy "+nombre;
    }
    public virtual void getSaluda()
    {
        Console.WriteLine(setSaluda());
    }
    public /*virtual*/ abstract void Toca();
    //{
        //Console.WriteLine($"{nombre} tocando su instrumento");
    //}
}

class Cantante:Musico
{
    public string ?mic {get; set;}
    public Cantante(string n):base(n)
    {
        this.nombre=n;
    }
    public override void getSaluda()
    {
        Console.WriteLine(setSaluda()+" y soy cantante");
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
    public override void getSaluda()
    {
        Console.WriteLine(setSaluda()+" y soy bajista");
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
    public override void getSaluda()
    {
        Console.WriteLine(setSaluda()+" y soy baterista");
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
           m.getSaluda(); 
           m.Toca();
        }
    }
}
//los metodos abstractos no tienen implementacion
//se delegan de manera obligatoria