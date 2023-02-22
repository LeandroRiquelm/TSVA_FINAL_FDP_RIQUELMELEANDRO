using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pausePanel;
    bool pauseOn;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    // Update is called once per frame
    void Update()
    {
        
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                pauseOn = !pauseOn;
                pausePanel.SetActive(pauseOn);

                Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            if (!pauseOn)
                {
                    Time.timeScale = 1;
                }
                else
                {
                    Time.timeScale = 0;
                }
            }

        
    }
   
   

    public void PauseOff()
    {
        pauseOn = !pauseOn;
        pausePanel.SetActive(false);
        Time.timeScale = 1;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    public void ToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void SelectSecene()
    {
        SceneManager.LoadScene(1);

        Time.timeScale = 1;
    }

}
