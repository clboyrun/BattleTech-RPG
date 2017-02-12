using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngineCalls : MonoBehaviour {
    
    public static MenuOptions CurrentMenu = MenuOptions.None;
    public static MenuOptions LoadMenu = MenuOptions.MainMenu;

    public enum MenuOptions
    {
        None,
        MainMenu,
        CreateCharacter,
        Lobby
    }

    public static void LoadScreen()
    {

    }
}
