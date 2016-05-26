using DamGame;
using Matrix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        bool fullScreen = false;
        Hardware.Init(1024, 768, 24, fullScreen);
        bool finished = false;

        while (!finished)
        {
            WelcomeScreen welcome = new WelcomeScreen();
            welcome.Run();

            if (welcome.GetOptionChosen() == WelcomeScreen.options.Credits)
            {
                CreditsScreen credits = new CreditsScreen();
                credits.Run();
            }

            if (welcome.GetOptionChosen() == WelcomeScreen.options.Play)
            {
               // Matrix myMatrix = new Matrix();
                //myMatrix.Run();
            }

            if (welcome.GetOptionChosen() == WelcomeScreen.options.Quit)
                finished = true;
        }
    }
}
