using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {
    #region ClassAtributes
    //Class atributes
    //These arrays will hold the password of the different game's levels
    string[] passwordLevel1 = { "book", "class", "teacher", "room", "hour" };
    string[] passwordLevel2 = { "cashier", "department", "payment", "electronic" };
    string[] passwordLevel3 = { "dossier", "international", "security" };

    //Here i declare an enumarated type to represent the different game states
    //and i declare a variable to hold the current game state
    enum gameState { MainMenu, Password, Win};
    gameState currentState;

    //This variable should recieve the user's input
    string input;
    #endregion

    // Use this for initialization
    void Start () {
        ShowMainMenu();
	
	}

    private void ShowMainMenu()
    {
        currentState = gameState.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine("What do you want to hack today?");
        Terminal.WriteLine("1. Town's college");
        Terminal.WriteLine("2. City's Super Center");
        Terminal.WriteLine("3. NSA Server");
        Terminal.WriteLine("Option?");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
