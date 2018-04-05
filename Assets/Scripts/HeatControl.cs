using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeatControl : MonoBehaviour {

    public Transform player;
    public ParticleSystem heat;
    public bool hasObject = true; 

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (hasObject)
        {

            var d = Input.GetAxis("Mouse ScrollWheel");

            if (d > 0f)
            {
                heat.Play();
            }
            else if (d < 0f)
            {
                heat.Stop();
            }
        }
    }
}
