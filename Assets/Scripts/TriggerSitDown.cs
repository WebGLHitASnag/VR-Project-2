using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSitDown : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    void OnTriggerEnter(Collider other)
    {
        // Whenever the camera touches the desk, do the following to clip the user into the chair
        if (other.attachedRigidbody) { // Saftey check
            other.transform.position = new Vector3((float)0.01782853, (float)-0.8989514, (float)5.91886); // Set the position
            other.transform.rotation = Quaternion.Euler(0, -180, 0); // Set the rotation
        }
    }

}
