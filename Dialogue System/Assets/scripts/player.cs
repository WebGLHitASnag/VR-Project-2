using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// link animator to controller

public class player : MonoBehaviour {

    public Animator anim;


    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();


	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("1"))
        {
            anim.Play("WAIT01", -1, 0f);
        }
        if (Input.GetKeyDown("2"))
        {
            anim.Play("WAIT02", -1, 0f);
        }
        if (Input.GetKeyDown("3"))
        {
            anim.Play("WAIT03", -1, 0f);
        }
        if (Input.GetKeyDown("4"))
        {
            anim.Play("WAIT01", -1, 0f);
        }
    }
}
