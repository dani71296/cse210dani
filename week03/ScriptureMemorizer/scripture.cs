using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private Reference _reference;
    private List<Word> _listWords= new List<Word> ();
    public Scripture (Reference reference, string texto)
    {
        _reference = reference;
         string[] wordsArray = texto.Split(' '); 
        foreach (string word in wordsArray)
        {
            _listWords.Add(new Word(word, false)); 
        }
    }
    public string DisplayScripture()
    {
        string referencia =_reference.GetReference();
        string texto = string.Join(" ", _listWords.Select(w => w.GetHiddenWord()));
        return $"{referencia}\n{texto}";

    }
    public void HideRandomWords(int count)
    {
        Random random = new Random();
        int ocultadas = 0;

        while (ocultadas < count)
        {
            int index = random.Next(0, _listWords.Count); 
            if (!_listWords[index].IsHidden())
            {
            _listWords[index].HiddeWord(); 
            ocultadas++; 
            }
        }
    }
}