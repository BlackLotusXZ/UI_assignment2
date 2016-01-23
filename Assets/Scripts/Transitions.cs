using UnityEngine;
using System.Collections;

public class Transitions : MonoBehaviour {
    /*******  These are the functions to call when you want to transition from screen to screen  ********/

    //trigger this when the button is tapped while on splashscreen
    public void LoadMainMenu()
    {
        Debug.Log("Main Menu Screen Load");
        Application.LoadLevel("Main_Menu_Screen"); //move to the main menu screen
    }

    //trigger this when the Quest button is tapped on while in main menu screen this will lead to the first level selection screen where it will only show the first level.
    public void LoadLevelSelect()
    {
        Debug.Log("Level Select Type 1 Load");
        Application.LoadLevel("Level_Select_Screen_1");
    }

    //trigger this when the Quest button is tapped on while in main menu screen this will lead to the second level selection screen where it will only show the first level cleared and the new second level.
    public void LoadSecondLevelSelect()
    {
        Debug.Log("Level Select Type 2 Load");
        Application.LoadLevel("Level_Select_Screen_2");
    }

    //trigger this when the Menu button is tapped on while in main menu screen
    public void LoadOptionsScreen()
    {
        Debug.Log("Option Screen Load");
        Application.LoadLevel("Options_Screen");
    }

    //trigger this when Level 1 selection is clicked on. To the gameplay screen
    public void LoadGamePlay_One()
    {
        Debug.Log("Gameplay Level One Load");
        Application.LoadLevel("Gameplay");
    }
}
