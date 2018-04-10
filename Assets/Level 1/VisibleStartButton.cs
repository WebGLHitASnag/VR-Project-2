using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VisibleStartButton : MonoBehaviour {
    public GameObject cam;
    GameObject start_dialogue;
    Vector3 desired_position = new Vector3(171.3f, 43.7f, -430.5f);
    public GameObject parentObject;
    bool inst = true;
    
    // Use this for initialization
    void Start () {
        start_dialogue = HelpMe.FindObject(parentObject, "TestButton");
    }

    // Update is called once per frame
    void Update() {
        if (inst) { 
            if ((cam.GetComponent<Transform>().transform.position.x > desired_position.x) && (cam.GetComponent<Transform>().transform.position.z < desired_position.z)) {
                inst = false;
                start_dialogue.SetActive(true);
            }
        }

    }

}


static class HelpMe {

    public static GameObject FindObject(this GameObject parent, string name)
    {
        Transform[] trs = parent.GetComponentsInChildren<Transform>(true);
        foreach (Transform t in trs)
        {
            if (t.name == name)
            {
                return t.gameObject;
            }
        }
        return null;
    }
}
