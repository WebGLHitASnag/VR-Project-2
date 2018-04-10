using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LakeHeatAndRain : MonoBehaviour {

    public Transform guide;
    public GameObject targetCube = null;
    public GameObject player = null;
    public GameObject cloud;
    public GameObject water;
    public GameObject sun;
    public ParticleSystem heat;
    public ParticleSystem rain;
    public bool shrinking = true;
    public bool start = false;
    public int particleCountHeat;
    public int particleCountRain;
    public float targetScale = 0.1f;
    public float speed;
    public float endWater;
    public float startWater;
    public float units = 5.0f;
    public Vector3 directionWater;

    private void OnParticleCollision(GameObject other) {
        if (other.tag == "Heat") {
            CountParticleHeat();
        }
        else if (other.tag == "Rain") {
            CountParticleRain();
        }
    }

    public void CountParticleHeat() {
        particleCountHeat = particleCountHeat + 1;
    }

    public void CountParticleRain() {
        particleCountRain = particleCountRain + 1;
    }

    void Start() {
        rain.Pause();
        startWater = water.transform.position.y;
        endWater = water.transform.position.y - units;
    }

    void Update() {
        //lowers water and expands cloud
        if (particleCountHeat > 250) {
            if (directionWater == Vector3.down) { 
                speed = 1.0f;
            }

            if (directionWater == Vector3.up) {
                speed = 0.0f;
            }

            water.transform.Translate(directionWater * speed * Time.deltaTime);

            if (water.transform.position.y >= startWater) {
                directionWater = Vector3.down;
            }

            if (water.transform.position.y <= endWater) {
                directionWater = Vector3.up;
            }

            if (water.transform.position.y <= endWater) {
                while (cloud.transform.localScale.x < 20.0) {
                    cloud.transform.localScale += new Vector3(2.0f, 2.0f, 2.0f) * Time.deltaTime;
                }
                rain.Play();
                heat.Stop();
            }
        }

        //raises water and makes cloud disappear
        if (particleCountRain > 300) {
            rain.Stop();
            directionWater = Vector3.up;
            speed = 1.0f;
            water.transform.Translate(directionWater * speed * Time.deltaTime);
            if (water.transform.position.y >= startWater) {
                directionWater = Vector3.down;
                speed = 0.0f;
                while (cloud.transform.localScale.x > 0.0001) { 
                    cloud.transform.localScale -= Vector3.one * Time.deltaTime * 0.1f;
                }
                start = true;
                particleCountRain = 0;
                particleCountHeat = 0;
                sun.GetComponent<Rigidbody>().useGravity = true;
                sun.GetComponent<Rigidbody>().isKinematic = false;
                sun.transform.parent = null;
                sun.transform.position = guide.transform.position;
            }
            if (start) {
                sun.transform.position = new Vector3(4766.667f, 197.73f, -447.4175f);
                player.transform.position = targetCube.transform.position;
                start = false;
            }
        }
    }
}