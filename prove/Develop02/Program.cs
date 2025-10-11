using System;

class Program
{
    static void Main(string[] args)
    {
        Menu initMenu = new Menu();
        PromptGenerator initPrompt = new PromptGenerator();
        initPrompt.PromptInit();
        initMenu.Display(initPrompt);
    }
}