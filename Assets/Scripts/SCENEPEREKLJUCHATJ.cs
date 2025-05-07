using UnityEngine;
using UnityEngine.SceneManagement;

public class SCENEPEREKLJUCHATJ : MonoBehaviour
{
    public void ToAOAScene()
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
