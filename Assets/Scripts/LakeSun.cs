using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class LakeSun : MonoBehaviour {

    public Text tempText;
    private int startTemp;
    public Transform player;
    public Transform guide;
    public GameObject item;
    public GameObject tempParent;
    public ParticleSystem heat;
    public bool hasPlayer = false;
    public bool hasObject = false;
    public bool isPlaying = false;

    void Start() {
        heat.Play();
        item.GetComponent<Rigidbody>().useGravity = true;
        startTemp = 70;
        tempText.text = "";
    }

    void Update() {
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

        if (!hasObject) {
            heat.Pause();
        }

        if (hasObject) {
            var d = Input.GetAxis("Mouse ScrollWheel");
            var main = heat.main;

            if (d > 0f) {
                heat.Play();
                isPlaying = true;
            }

            else if (d < 0f) {
                heat.Stop();
                isPlaying = false;
            }

            if (isPlaying && Input.GetKey(KeyCode.E)) {
                main.gravityModifierMultiplier = main.gravityModifierMultiplier * 1.2f;
                startTemp++;
                string temp = startTemp.ToString();
                tempText.text = temp + "F";
            }

            if (isPlaying && Input.GetKey(KeyCode.R)) {
                main.gravityModifierMultiplier = main.gravityModifierMultiplier * 0.9f;
                startTemp--;
                string temp = startTemp.ToString();
                tempText.text = temp + "F";
            }

            if (player.transform.position.x >= 2220f && player.transform.position.x <= 2240f &&
            player.transform.position.y >= 853f && player.transform.position.y <= 870f &&
            player.transform.position.z >= 1059f && player.transform.position.z <= 1070f) {
                tempText.text = "";
            }
        }
    }
}