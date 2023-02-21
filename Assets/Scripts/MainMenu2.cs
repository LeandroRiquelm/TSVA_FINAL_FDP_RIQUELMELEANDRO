using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu2 : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(1);

        Time.timeScale = 1;
    }
    public void QuitGame()
    {
        Application.Quit();
    }

}
