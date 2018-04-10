using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Used to manage scenes

public class TriggerLevel2Start : MonoBehaviour {

    public GameObject boat;
    float exit_position = -250;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if ((DialogueManager.continue_count >= 28) && (boat.GetComponent<Transform>().transform.position.x < exit_position)){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //Load Level 2
        }
	}
}
