using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {

    public Transform player;
    public GameObject item;
    public GameObject tempParent;
    public Transform guide;
    public bool hasPlayer = false;
    public bool hasObject = false;

	// Use this for initialization
	void Start () {
        item.GetComponent<Rigidbody>().useGravity = true;
	}
	
	// Update is called once per frame
	void Update () {
        float dist = Vector3.Distance(gameObject.transform.position, player.transform.position);

        if (dist <= 4f) {
            hasPlayer = true;
        }
        if (dist > 4f) {
            hasPlayer = false;
        }
        
        if (hasPlayer && Input.GetMouseButtonDown(0)) {
            item.GetComponent<Rigidbody>().useGravity = false;
            item.GetComponent<Rigidbody>().isKinematic = true;
            item.transform.position = guide.transform.position;
            item.transform.rotation = guide.transform.rotation;
            item.transform.parent = tempParent.transform;
            hasObject = true;
        }


        if (hasObject && Input.GetMouseButtonDown(1)) {
            item.GetComponent<Rigidbody>().useGravity = true;
            item.GetComponent<Rigidbody>().isKinematic = false;
            item.transform.parent = null;
            item.transform.position = guide.transform.position;
            hasObject = false;
        }
    }
}
