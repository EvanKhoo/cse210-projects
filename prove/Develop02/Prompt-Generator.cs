using System;

public class PromptGenerator
{
    public Random _randomPrompt = new Random();
    public List<string> _prompts;
    public int  _ranPrompt;

    public void PromptInit() {
        _prompts = new List<string>
            {
                "What did you do today?",
                "What did you do to better yourself today?",
                "Do anything stupid today?",
                "Hard day? That sucks, put down the pen and hit the gym."
            };
    }
    
    public string DisplayPrompt()
    {
        _ranPrompt = _randomPrompt.Next(0, _prompts.Count);
        return _prompts[_ranPrompt];
    }
}