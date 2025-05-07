using UnityEngine;
using UnityEngine.UI;

public class ButtonSound : MonoBehaviour
{
    public Button button;  // —сылка на кнопку
    public AudioSource audioSource;  // —сылка на аудио

    void Start()
    {
        button.onClick.AddListener(PlaySound);
    }

    void PlaySound()
    {
        audioSource.Play();
    }
}
