using UnityEngine;
using UnityEngine.UI;

public class RotatImage : MonoBehaviour
{
    public Slider slider;  // ������ �� �������
    public RectTransform imageTransform; // ������ �� �����������

    void Start()
    {
        // ������������� �� ��������� �������� ��������
        slider.onValueChanged.AddListener(RotateImag);
    }

    void RotateImag(float value)
    {
        imageTransform.rotation = Quaternion.Euler(0, 0, value);
    }
}
