using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class WelcomeScreen
    {
        public enum options { Play, Credits, Quit };
        private options optionChosen;

        public void Run()
        {
            Font font18 = new Font("data/Joystix.ttf", 18);
            Image matrix = new Image("data/matrices.png");
            Image welcomeText = Hardware.CreateImageFromText("SPACE or P to Play, Q to Quit, C for Credits",
                    0xCC, 0xCC, 0xCC,
                    font18);


            bool validOptionChosen = false;

            do
            {
                Hardware.ClearScreen();
                Hardware.DrawHiddenImage(welcomeText, 40, 10);

                Hardware.DrawHiddenImage(matrix, 400, 300);
                Hardware.ShowHiddenScreen();

                if (Hardware.KeyPressed(Hardware.KEY_SPC) ||
                    Hardware.KeyPressed(Hardware.KEY_P))
                {
                    validOptionChosen = true;
                    optionChosen = options.Play;
                }
                if (Hardware.KeyPressed(Hardware.KEY_Q))
                {
                    validOptionChosen = true;
                    optionChosen = options.Quit;
                }
                if (Hardware.KeyPressed(Hardware.KEY_C))
                {
                    validOptionChosen = true;
                    optionChosen = options.Credits;
                }
                Hardware.Pause(50);
            }
            while (!validOptionChosen);
        }

        public options GetOptionChosen()
        {
            return optionChosen;
        }
    }
}
