// methods you would do to a journal to interact
// with it like Save the journal, Load the Journal,
// Write an entry in the journal, etc.



using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.IO;
using Microsoft.VisualBasic; // Don't forget to put this at the top, so C# knows where to find the StreamWriter class

public class Journal
{
    List<Entry> _entries = new List<Entry>(); //Le paso la clase Entry ya que estoy almacenando objetos de este tipo de datos
    string[] questions = {"Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?"
    };

    Random rnd = new Random();

    public void AddEntry()
    {
        int ind = rnd.Next(questions.Length);
        Console.WriteLine("{0}", questions[ind]);
        string response = Console.ReadLine();
        Entry new_entry = new Entry(questions[ind], response);
        _entries.Add(new_entry); //agregar el objeto que va a recibir el metodo addEntry a la lista _entries

    }

    public void displayEntries()
    {
        foreach (Entry savedEntry in _entries) //la lista que quiero recorrer siempre va a la derecha del in. A la izquierda va la variable que representa cada elemento de la lista. savedFiel apenas la creamos
        //La parte izquierda del in se divide en dos partes, el tipo de dato y nombre de la variable. El tipo de dato se puede sustituir por el nombre de una clase si loque se busca es usar un objeto  
        //Si vas a recorrer una lista de entradas, la variable debe de ser de entradas. Lo mismo con int y string.
        {
            Console.WriteLine($"{savedEntry}");
        }

    }

    public void loadFile(string nombrearchivo)
    {
        if (File.Exists(nombrearchivo))
        {
            string[] entradas = System.IO.File.ReadAllLines(nombrearchivo); //Nos pide corchetes porque System.IO.File.ReadAllLines es un metodo que regresa un arreglo de strings
            //Se usan los corchetes porque necesitamos guardar las respuestas en un arreglo de strings
            //System.IO.File.ReadAllLines = lee mi archivo y linea por linea la va a guardar en el arreglo entradas
            foreach (string entrada in entradas)
            {
                string[] data = entrada.Split(" - ");
                /*foreach (string d in data){
                    Console.WriteLine(d);
                }*/
                Entry adentry = new Entry(data[1], data[2]);
                _entries.Add(adentry);
                Console.WriteLine(entrada);
            }
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }
    }

    public void saveFile(string nombrearchivo)
    {
        //estoy ocupando mi variable global - El nombre que me de el usuario se va a usar tanto para guardar como para buscar
        using (StreamWriter outputFile = new StreamWriter(nombrearchivo))
        {
            // You can add text to the file with the WriteLine method
            foreach (Entry entradaDelUsuario in _entries)
            {
                outputFile.WriteLine(entradaDelUsuario);
            }
        }
    }
}