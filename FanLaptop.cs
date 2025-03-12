using System;
using Microsoft.VisualBasic.FileIO;

public class FanLaptop
{
    public enum fan { Quiet, Balanced, Performance, Turbo }

    public enum trigger { Up, Down, Shortcut }

    private fan state;

    public FanLaptop()
	{
        state = fan.Quiet;
	}

    public void StateChange(trigger option)
    {
        switch (state)
        {
            case fan.Quiet:
                if (option == trigger.Up)
                {
                    Console.WriteLine("Fan Quiet berubah menjadi Balanced");
                    state = fan.Balanced;
                }
                else if (option == trigger.Shortcut)
                {
                    Console.WriteLine("Fan Quiet berubah menjadi Turbo");
                    state = fan.Turbo;

                }
                break;

            case fan.Balanced:
                if (option == trigger.Up)
                {
                    Console.WriteLine("Fan Balanced berubah menjadi Performance");
                    state = fan.Performance;
                }
                else if (option == trigger.Down)
                {
                    Console.WriteLine("Fan Balanced berubah menjadi Quiet");
                    state = fan.Quiet;
                }
                break;

            case fan.Performance:
                if (option == trigger.Up)
                {
                    Console.WriteLine("Fan Performance berubah menjadi Turbo");
                    state = fan.Turbo;
                }
                else if (option == trigger.Down)
                {
                    Console.WriteLine("Fan Performance berubah menjadi Balanced");
                    state = fan.Balanced;
                }
                break;

            case fan.Turbo:
                if (option == trigger.Shortcut)
                {
                    Console.WriteLine("Fan Turbo berubah menjadi Quiet");
                    state = fan.Quiet;
                }
                else if (option == trigger.Down)
                {
                    Console.WriteLine("Fan Turbo berubah menjadi Performance");
                    state = fan.Performance;
                }
                break;
        }
    }

    public void GetFanStatus()
    {
        Console.WriteLine("Fan: " + state);
    }
}
