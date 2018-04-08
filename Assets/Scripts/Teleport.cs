using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    public GameObject TargetCube = null;
    public GameObject Player = null;


    // Update is called once per frame
    void Update() {
        
    }

    void OnTriggerEnter(Collider other) {
        Player.transform.position = TargetCube.transform.position;
    }
}