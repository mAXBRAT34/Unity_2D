using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageScript : MonoBehaviour
{
    public GameObject bean;
    public GameObject teddy;
    public GameObject car;
    public GameObject lady;
    public GameObject left;
    public GameObject right;
    public GameObject imageField;
    public Sprite[] soriteArray;
    public void DropDown(int index)
    {
        if (index == 0)
            imageField.GetComponent<Image>().sprite = soriteArray[0];
        else if (index == 1)
            imageField.GetComponent<Image>().sprite = soriteArray[1];
        else if (index == 2)
            imageField.GetComponent<Image>().sprite = soriteArray[2];
    }
    public void ToggleBean(bool value)
    {
        bean.SetActive(value);
        left.GetComponent<Toggle>().interactable = value;
        right.GetComponent<Toggle>().interactable = value;
    }

    public void ToggleTeddy(bool value)
    {
        teddy.SetActive(value);
    }

    public void ToggleCar(bool value)
    {
        car.SetActive(value);
    }

    public void ToggleLady(bool value)
    {
        lady.SetActive(value);
    }

    public void ToLeft()
    {
        bean.transform.localScale = new Vector2 (1, 1);
    }

    public void ToRight()
    {
        bean.transform.localScale = new Vector2(-1, 1);
    }
}
