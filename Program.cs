// See https://aka.ms/new-console-template for more information
using Ci;
using ICsefa;
using ISOCODE;
using Terminal.Gui;
using System;
using MenuW;
namespace Csefa;
public static class Program
{
    public static int Main(string[] args)
    {
        /*if (args is null)
        {
            throw new ArgumentNullException(nameof(args));
        }*/
        MenuWindow menuWindow = new MenuWindow();
        
        /*Console.WriteLine("Press Enter to continue...");
        if (!(Console.ReadKey(true).Key == ConsoleKey.Enter))
        {
            Console.WriteLine("F12 not pressed, exiting...");
            return 1;
        }*/
        string path_now = Environment.CurrentDirectory;
        bool autoStart = false;
        if (File.Exists(path_now + "/data/autostart"))
        {
            autoStart = true;
        }
        if (autoStart)
        {
            
            Console.WriteLine("F2 to enter menu, starting in ");
            StartCountdown(3);
            if (Console.ReadKey(true).Key == ConsoleKey.F2)
            {
                menuWindow.Menu();
            }
            else
            {
                FastInit();
            }
        }

        /*if (autoStart == false)
        {
            menuWindow.Menu();
        }*/
        menuWindow.Menu();
        return 0;
    }
    static void FastInit()
    {
        Console.WriteLine("Will available soon, exiting...");
    }
    public static void Install()
    {
        //Console.WriteLine("(a) Auto Start - F2 To enter menu");
        /*if (File.Exists("csefa/iso/csefa.iso"))
        {
            Console.WriteLine("csefa.iso exists, continuing...");
        }*/
        //else
        //{
            Console.Write("Insert the path to the ISO file: ");
            string pathIso = Console.ReadLine();
            ICsefaISO csefaIso = new CsefaIso();
            IsoCode result = csefaIso.RIso(pathIso, true);
            int resultInt = (int)result;
            IsoCodeMean isoCodeMean = new IsoCodeMean();
            string resultMean = isoCodeMean.ICM(result);
            Console.WriteLine("Exit with code " + resultMean + " (" + resultInt + ")");
        //}
    }
    static void StartCountdown(int countdownSeconds)
    {
        for (int i = countdownSeconds; i > 0; i--)
        {
            Console.Write($"\r{i}");
            Thread.Sleep(1000);
        }
    }
}

