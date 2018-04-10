using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetStart : MonoBehaviour {
    public GameObject playCam;
    bool happen = true;
    Vector3 desired_position = new Vector3(2229.4f, 856.4f, 1096.1f);
    // Use this for initialization
    void Start()
    {
       
    }
    // Update is called once per frame
    void Update () {
        if (happen) {
            happen = false;
            while (playCam.GetComponent<Transform>().transform.position != desired_position) {
                playCam.GetComponent<Transform>().transform.position = desired_position;
            }
        }
    }
}
