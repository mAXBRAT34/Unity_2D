using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change : MonoBehaviour
{
    public void ToUIScene()
    {
        SceneManager.LoadScene("FirstScene", LoadSceneMode.Single);

    }
    public void ToMainMenu()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);

    }
    public void Quit()
    {
        Application.Quit();
    }

}
