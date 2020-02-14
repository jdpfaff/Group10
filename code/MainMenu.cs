using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;


public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        // The main menu is under Scene 0 and the actual game is under scene 1
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Quit()
    {
        Application.Quit();
        // This is only used when in the Unity Editor, or else it wouldn't close when in the editor
        EditorApplication.isPlaying = false;
    }
}
