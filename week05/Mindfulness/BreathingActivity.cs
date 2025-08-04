public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }

    public void Run()
    {
        // Show starting message and get updated duration
        DisplayStartingMessage();

        int duration = GetDuration();
        int elapsedTime = 0;

        while (elapsedTime < duration)
        {
            Console.WriteLine();
            Console.Write("Breathe in... ");
            ShowCountDown(3);
            elapsedTime += 3;
            if (elapsedTime >= duration) break;

            Console.Write("Now breathe out... ");
            ShowCountDown(3);
            elapsedTime += 3;
        }

        DisplayEndingMessage();
    }
}