using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetTextScript : MonoBehaviour
{
    private int number = 0;
    string text;
    public string[] textArray = {"Sveiks ", "Jauku dienu ", 
    "Prieks Tevi redzēt ", "Uz tikšanos ", "Lai Tev labi iet "};
    int randText;
    public GameObject inputField;
    public GameObject textField;

    public void ShowText()
    {
        randText = Random.Range(0, textArray.Length);
        text = inputField.GetComponent<Text>().text;
        textField.GetComponent<Text>().text = 
            textArray[randText] + text.ToUpper()+"!";
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Skaitlis: "+number);
        number++;
    }
}
