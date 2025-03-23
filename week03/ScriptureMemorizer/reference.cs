using System;

class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;
    public Reference(string book, int chapter, int verse)
    {
        this._book = book; // usare en este caso this solo para recordar que en caso no tuviera "_" entonces el this me ayudaria a distinguir pero en este caso no es necesariio
        this._chapter = chapter;
        this._startVerse = verse;
        this._endVerse = verse;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
       _book = book;
       _chapter = chapter;
       _startVerse = startVerse;
       _endVerse = endVerse;
    }
    public  string GetReference()
    {
        if(_startVerse == _endVerse)
        return $"{_book} {_chapter}:{_startVerse}";
        else
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
    }
}