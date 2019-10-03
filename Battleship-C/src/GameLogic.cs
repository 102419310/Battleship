using SwinGameSDK;
using System;

public static class GameLogic
{
    public static void Main()
    {
        SwinGame.SetIcon("Icon.ico");

        // Opens a new Graphics hhhhhh Window:
        SwinGame.OpenGraphicsWindow("Battle Ships", 800, 600);

        // Load Resources:

        GameResources.LoadResources();
        SwinGame.PlayMusic(GameResources.GameMusic("Background"));
        
        GameController.Init();

        // Main Game Loop:
        while (!SwinGame.WindowCloseRequested() && !(GameController.CurrentState == GameState.Quitting))
        {
            GameController.HandleUserInput();
            GameController.DrawScreen();
        }

        // Stop Music, Free Resources and Close Audio, to end the program.
        SwinGame.StopMusic();
        GameResources.FreeResources();
    }

}