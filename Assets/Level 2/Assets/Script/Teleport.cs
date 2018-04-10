using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Teleport : MonoBehaviour {

    public GameObject endCube;
    public GameObject targetCube = null;
    public GameObject player = null;
    public Text timerText;
    private float startTime;
    public bool hit = false;

    void Update() {
        if (hit) {
            float t = Time.time - startTime;
            string minutes = ((int)t / 60).ToString();
            string seconds = (t % 60).ToString("f2");
            timerText.text = minutes + ":" + seconds;
        }

        if (player.transform.position.x >= 2220f && player.transform.position.x <= 2240f && 
            player.transform.position.y >= 853f && player.transform.position.y <= 870f &&
            player.transform.position.z >= 1059f && player.transform.position.z <= 1070f) {
            hit = false;
        }
    }

    void OnTriggerEnter(Collider other) {
        startTime = Time.time;
        hit = true;
        player.transform.position = targetCube.transform.position;
    }
}