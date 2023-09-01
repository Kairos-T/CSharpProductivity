using System;
using System.Collections.Generic;

class DecisionMaker
{
    private List<string> options;

    public DecisionMaker()
    {
        options = new List<string>();
    }

    public void AddOption(string option)
    {
        options.Add(option);
        Console.WriteLine("Option added.");
    }

    public string GenerateDecision()
    {
        if (options.Count == 0)
        {
            return "No options entered.";
        }

        Random random = new Random();
        int randomIndex = random.Next(0, options.Count);
        return options[randomIndex];
    }
}
