using System;
using System.Collections.Generic;

class PromptGenerator
{
    private List<string> prompts;

    public PromptGenerator()
    {
        prompts = new List<string>
        {
            "¿Who was the most interesting person I interacted with today?",
            "¿What was the best part of my day?",
            "¿How did I see the hand of the Lord in my life today?",
            "¿What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
    }

    public string GenerarPreguntaAleatoria()
    {
        Random rand = new Random();
        int index = rand.Next(prompts.Count);
        return prompts[index];
    }
}