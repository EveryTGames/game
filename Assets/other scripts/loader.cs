using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loader : MonoBehaviour
{
    public void start()
    {
        SceneManager.LoadScene(1);
    }

    public void quit()
    {
        Application.Quit();

    }
}
