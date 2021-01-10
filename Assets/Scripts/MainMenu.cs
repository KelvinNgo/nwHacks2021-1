using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame ()
    {
        // Loads the next level/scene
        SceneManager.LoadScene(1);
    }

    public void ExitGame () 
    {
        Debug.Log("Quit game");
        // Exits the game
        Application.Quit();
    }

    public void ExitGameOver()
    {
        SceneManager.LoadScene(0);
    }
}
