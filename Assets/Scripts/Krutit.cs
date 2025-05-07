using UnityEngine;
using UnityEngine.UI;

public class RotatImage : MonoBehaviour
{
    public Slider slider;  // Ссылка на слайдер
    public RectTransform imageTransform; // Ссылка на изображение

    void Start()
    {
        // Подписываемся на изменение значения слайдера
        slider.onValueChanged.AddListener(RotateImag);
    }

    void RotateImag(float value)
    {
        imageTransform.rotation = Quaternion.Euler(0, 0, value);
    }
}
