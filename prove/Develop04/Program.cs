using System;

class Program
{
    public static int[] logs = new int[3];
    static void Main(string[] args)
    {
        bool _running = true;
        while (_running)
        {
            // Display the menu and select a subclass
            switch (Activity.DisplayMenu())
            {
                case 1:
                    logs[0]++;
                    new BreathingActivity().RunActivity();
                    break;
                case 2:
                    logs[1]++;
                    new ReflectionActivity().RunActivity();
                    break;
                case 3:
                    logs[2]++;
                    new ListingActivity().RunActivity();
                    break;
                case 4:
                    _running = false;
                    break;
                default:
                    break;
            }
        }
    }
}