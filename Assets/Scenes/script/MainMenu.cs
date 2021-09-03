using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{

    public GameObject levels;
    public GameObject play;

    public void Levelsbuttons()
    {
        levels.active =true;
        play.active=false;
    }

    public void Exit()
    {
        Application.Quit();
    }
}
