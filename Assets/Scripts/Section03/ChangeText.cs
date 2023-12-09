using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeText : MonoBehaviour
{

    public GameObject sign;
    public int number;
    public string hotdogType;
    public float price;

    // Start is called before the first frame update
    void Start()
    {
        hotdogType = "Bratwurst";
        price = 8.99f;

        //sign.GetComponent<TextMeshPro>().text = number.ToString(); 
        //TMPro.text only accepts strings so number.ToString(); converts int to string

        //sign.GetComponent<TextMeshPro>().text = hotdogType + price.ToString();
        //strings can be added together.

        sign.GetComponent<TextMeshPro>().fontSize = 12;
        sign.GetComponent<TextMeshPro>().text = "Programmer Land";


    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
