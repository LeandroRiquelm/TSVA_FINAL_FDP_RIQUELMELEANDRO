using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneSelection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

       
    }
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