using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {

    Animation anim = new Animation();

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animation>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LeaveScreen()
    {
        EngineCalls.LoadMenu = EngineCalls.MenuOptions.CreateCharacter;
        anim.Play();
    }

    public void LoadNextScreen()
    { EngineCalls.LoadScreen(); }
}
