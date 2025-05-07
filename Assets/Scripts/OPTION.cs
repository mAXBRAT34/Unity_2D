using UnityEngine;
using UnityEngine.UI;

public class DropdownImageSwitcher : MonoBehaviour
{
    public Dropdown dropdown; // Ссылка на UI Dropdown
    public Image imageDisplay; // Ссылка на UI Image
    public Sprite[] sprites; // Массив изображений

    void Start()
    {
        dropdown.onValueChanged.AddListener(ChangeImage);
    }

    void ChangeImage(int index)
    {
        if (index >= 0 && index < sprites.Length)
        {
            imageDisplay.sprite = sprites[index]; // Меняем изображение
        }
    }
}
