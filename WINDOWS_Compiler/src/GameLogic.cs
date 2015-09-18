
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using SwinGameSDK;
using static Battleships.GameController;
using static Battleships.UtilityFunctions;
using static Battleships.GameResources;
using static Battleships.DiscoveryController;
using static Battleships.EndingGameController;
using static Battleships.MenuController;
using static Battleships.HighScoreController;

namespace Battleships
{

    static class GameLogic
    {
        public static void Main()
        {
            //Opens a new Graphics Window
            SwinGame.OpenGraphicsWindow("Battle Ships", 800, 600);
            
            //Load Resources
            LoadResources();
            
            SwinGame.PlayMusic(GameMusic("Background"));
            
            //Game Loop
            do {
                HandleUserInput();
                DrawScreen();
            } while (!(SwinGame.WindowCloseRequested() == true | CurrentState == GameState.Quitting));
            
            SwinGame.StopMusic();
            
            //Free Resources and Close Audio, to end the program.
            FreeResources();
        }
    }
    
    //=======================================================
    //Service provided by Telerik (www.telerik.com)
    //Conversion powered by NRefactory.
    //Twitter: @telerik
    //Facebook: facebook.com/telerik
    //=======================================================
    
}