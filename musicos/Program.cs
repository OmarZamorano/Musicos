class Musico
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
    public virtual void Toca()
    {
        Console.WriteLine($"{nombre} tocando su instrumento");
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
        Beatles.Add(new Musico("Paul McCartney"));
        Beatles.Add(new Musico("John Lennon"));
        Beatles.Add(new Bajista("Jorsh Harrisson","Höfner"));
        Beatles.Add(new Baterista("Ringo Star","LudWig"));

        foreach(var m in Beatles)
        {
           m.Saluda(); 
           m.Toca();
        }

        Musico m1 = new Musico("Paul McCartney");
        //m1.Saluda();
        //m1.Toca();

        Musico m2 = new Musico("John Lennon");
        //m2.Saluda();
        //m2.Toca();

        Bajista m3 = new Bajista("Jorsh Harrisson","LudWig");
        //m3.Saluda();
        //m3.Toca();

        Baterista m4= new Baterista("Ringo Star","LudWig");
        //m4.Saluda();
        //m4.Toca();
    }
}