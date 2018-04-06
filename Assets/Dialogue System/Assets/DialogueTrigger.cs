using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTrigger : MonoBehaviour {

	public Dialogue dialogue;
    public GameObject button;
	public void TriggerDialogue ()
	{
        Debug.Log("WTF");
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        GameObject.Destroy(GameObject.FindGameObjectsWithTag("StartButton")[0]);
    }

}
