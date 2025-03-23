using System;

class Word
{
    private string _word;
    private bool _isHidden;
    public Word (string word, bool estado = false)
    {
        _word = word;
        _isHidden = estado;
    }
    public  void HiddeWord()
    {
        _isHidden=true;
    }
    public string GetHiddenWord()
    {
       if (_isHidden)
        {
            return new string('_', _word.Length);
        }
       else
        {
            return _word;
        }
    }
    public bool IsHidden()
    {
        return _isHidden;
    }

}