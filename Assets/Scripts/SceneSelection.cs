using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelection : MonoBehaviour
{
  
     public void Scene1()
     {
            SceneManager.LoadScene(2);

            Time.timeScale = 1;
     }

    public void Scene2()
    {
        SceneManager.LoadScene(3);

        Time.timeScale = 1;
    }

}
