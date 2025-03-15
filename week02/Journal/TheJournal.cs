using System;
using System.Collections.Generic;
using System.IO;
class Journal
{
    private List<Entry> entradas;

    public Journal()
    {
        entradas = new List<Entry>();
    }
    public void AgregarEntrada(string prompt, string respuesta)
    {
        Entry nuevaEntrada = new Entry(DateTime.Now.ToString("yyyy-MM-dd HH:mm"), prompt, respuesta);
        entradas.Add(nuevaEntrada);
        Console.WriteLine("ENTRY ADD SUCCESFULLY");
    }
     public void MostrarEntradas()
    {
        if (entradas.Count == 0)
        {
            Console.WriteLine("THE JOURNAL IS EMPTY.");
        }
        else
        {
            foreach (Entry entrada in entradas)
            {
                Console.WriteLine(entrada.MostrarEntrada());
            }
        }
    }
    public void GuardarEnArchivo(string nombreArchivo)
    {
        using (StreamWriter writer = new StreamWriter(nombreArchivo))
        {
            foreach (Entry entrada in entradas)
            {
                writer.WriteLine($"{entrada.Fecha}|{entrada.Prompt}|{entrada.Respuesta}");
            }
        }
        Console.WriteLine("JOURNAL SAVE SUCCESFULLY.");
    }
    public void CargarDesdeArchivo(string nombreArchivo)
    {
        if (File.Exists(nombreArchivo))
        {
            entradas.Clear();
            string[] lineas = File.ReadAllLines(nombreArchivo);
            foreach (string linea in lineas)
            {
                string[] partes = linea.Split('|');
                if (partes.Length == 3)
                {
                    entradas.Add(new Entry(partes[0], partes[1], partes[2]));
                }
            }
            Console.WriteLine("JOURNAL LOAD SUCCESFULLY.");
        }
        else
        {
            Console.WriteLine("THE FILE DOESNT EXIST.");
        }
    }
}