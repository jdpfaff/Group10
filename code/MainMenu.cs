using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        // The main menu is under Scene 0 and the actual game is under scene 1
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Quit()
    {
        // Debug to check in Unity editor
        Debug.Log("Quit game");
        Application.Quit();
    }
}
