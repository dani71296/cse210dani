using System;

class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool running = true;
        while (running)
        {
            Console.WriteLine("\nJOURNAL MENU");
            Console.WriteLine("1. WRITE A NEW ENTRY");
            Console.WriteLine("2. SHOW THE JOURNAL");
            Console.WriteLine("3. SAVE THE JOURNAL IN A FILE");
            Console.WriteLine("4. LOAD JOURNAL ");
            Console.WriteLine("5. EXIT");

            Console.Write("CHOOSE AN OPTION: ");
            string opcion = Console.ReadLine();

            if (opcion == "1")  
            {
                string prompt = promptGenerator.GenerarPreguntaAleatoria();
                Console.WriteLine($"QUESTION: {prompt}");
                Console.Write("YOUR ANSWER: ");
                string respuesta = Console.ReadLine();
                journal.AgregarEntrada(prompt, respuesta);
            }
            else if (opcion == "2")  
            {
                journal.MostrarEntradas();
            }
            else if (opcion == "3")  
            {
                Console.Write("NAME OF THE FILE TO SAVE: ");
                string archivoGuardar = Console.ReadLine();
                journal.GuardarEnArchivo(archivoGuardar);
            }
            else if (opcion == "4")  
            {
                Console.Write("NAME OF THE FILE TO LOAD: ");
                string archivoCargar = Console.ReadLine();
                journal.CargarDesdeArchivo(archivoCargar);
            }
            else if (opcion == "5")  
            {
                Console.WriteLine("THANKS TO USE THIS JOURNAL!");
                running = false;
            }
            else  
            {
                Console.WriteLine("INVALID OPTION TRY AGAIN.");
            }
        }
    }
}