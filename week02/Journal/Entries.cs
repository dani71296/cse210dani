using System;

class Entry
{
    public string Fecha { get; }
    public string Prompt { get; }
    public string Respuesta { get; }

    public Entry(string fecha, string prompt, string respuesta)
    {
        Fecha = fecha;
        Prompt = prompt;
        Respuesta = respuesta;
    }

    public string MostrarEntrada()
    {
        return $"[{Fecha}] QUIESTION: {Prompt}\nANSWER: {Respuesta}\n";
    }
}