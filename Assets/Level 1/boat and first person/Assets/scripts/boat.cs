using UnityEngine;
using System.Collections;

public class boat : MonoBehaviour {

	public float turnSpeed = 5000f;
	public float accellerateSpeed = 5000f;

	private Rigidbody rbody;

	// Use this for initialization
    //have access to the boats rigidbody
	void Start () 
	{
		rbody = GetComponent<Rigidbody>();
	}
	
	// get the input we press
	void Update () 
	{
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");

		rbody.AddTorque(0f,h*turnSpeed*Time.deltaTime,0f);
        //push the direction which we are facing
		rbody.AddForce(transform.forward*v*accellerateSpeed*Time.deltaTime);


	}
}
