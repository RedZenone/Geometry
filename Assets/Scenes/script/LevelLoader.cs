using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;

    public void LoadONE()
    {
      StartCoroutine(LoadLevel("LevelOne"));
    }

    public void LoadTWO()
    {
      StartCoroutine(LoadLevel("LevelTwo"));
    }

    public void LoadTHREE()
    {
      StartCoroutine(LoadLevel("LevelThree"));
    }

    public void LoadMain()
    {
      StartCoroutine(LoadLevel("MainMenu"));
    }

    IEnumerator LoadLevel(string Levelname)
    {
      transition.SetTrigger("Start");
      yield return new WaitForSeconds(1);
      SceneManager.LoadScene(Levelname);
    }
}
