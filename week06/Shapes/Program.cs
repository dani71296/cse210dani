using System;

class Program
{
    static void Main(string[] args)
    {
        Square miCuadrado = new Square("rojo", 5.0); //a esto se llama instancia
         Console.WriteLine("Color: " + miCuadrado.GetColor());
        Console.WriteLine("Área: " + miCuadrado.GetArea());
    }
}