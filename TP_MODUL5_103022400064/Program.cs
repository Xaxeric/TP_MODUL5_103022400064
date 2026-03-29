using System;

class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine($"Halo user {user}");
    }
}

class DataGeneric<T>
{
    public T Data { get; set; }

    public DataGeneric(T data)
    {
        Data = data;
    }

    public void PrintData()
    {
        Console.WriteLine($"Data yang tersimpan adalah: {Data}");

    }
}

class Program
{
    static void Main(string[] args)
    {

        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser("praktikan");

        DataGeneric<string> dataNim = new DataGeneric<string>("103022400064");
        dataNim.PrintData();

    }
}
