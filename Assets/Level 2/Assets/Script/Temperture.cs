using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Temperature : MonoBehaviour
{

    public Text tempText;
    private int startTemp;
    // Use this for initialization
    void Start()
    {
        startTemp = 70;
    }

    // Update is called once per frame
    void Update()
    {
        // var d = Input.GetAxis("Mouse ScrollWheel");
        if (Input.GetKey(KeyCode.E))
        {
            startTemp++;
            string temp = startTemp.ToString();
            tempText.text = temp + "F";
        }
        else if (Input.GetKey(KeyCode.R))
        {
            startTemp--;
            string temp = startTemp.ToString();
            tempText.text = temp + "F";
        }
    }
}