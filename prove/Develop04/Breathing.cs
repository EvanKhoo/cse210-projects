public class Breathing : Activity
{
    public Breathing() : 
    base("Breathing Activity", "This activity will help you relax by " +
    "walking you through breathing in and out slowly. Clear your mind and " +
    "focuson your breathing.", 0)
    {

    }
    
    public void DoBreathing()
    {
        StartingMessage();

        for (int seconds = 0; seconds < _duration / 10; seconds++)
        {
            CountDown("Breathe in... ", 5);
            CountDown("Breathe out... ", 5);
        }
        EndingMessage();
    }
}    