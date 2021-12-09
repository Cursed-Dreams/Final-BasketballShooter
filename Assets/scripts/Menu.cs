using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public void Loadlevel(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void Quit()
    {
        Application.Quit();
    }
}

