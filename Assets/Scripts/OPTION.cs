using UnityEngine;
using UnityEngine.UI;

public class DropdownImageSwitcher : MonoBehaviour
{
    public Dropdown dropdown; // ������ �� UI Dropdown
    public Image imageDisplay; // ������ �� UI Image
    public Sprite[] sprites; // ������ �����������

    void Start()
    {
        dropdown.onValueChanged.AddListener(ChangeImage);
    }

    void ChangeImage(int index)
    {
        if (index >= 0 && index < sprites.Length)
        {
            imageDisplay.sprite = sprites[index]; // ������ �����������
        }
    }
}
