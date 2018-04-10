using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionPractice : MonoBehaviour {

    public GameObject cloud;
    public GameObject water;
    public ParticleSystem rain;
    public bool shrinking = true;
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

    void Update () {
        //lowers water and expands cloud
		if (particleCountHeat > 10) {
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
                while (cloud.transform.localScale.x < 10.0) {
                    cloud.transform.localScale += new Vector3(2.0f, 2.0f, 2.0f) * Time.deltaTime;
                }
                rain.Play();
            }
        }

        //raises water and makes cloud disappear
        if (particleCountRain > 20) {
            directionWater = Vector3.up;
            speed = 1.0f;
            water.transform.Translate(directionWater * speed * Time.deltaTime);
            if (water.transform.position.y >= startWater) {
                directionWater = Vector3.down;
                while (cloud.transform.localScale.x > 0.0001) {
                    cloud.transform.localScale -= Vector3.one * Time.deltaTime * 0.1f;
                }
                rain.Stop();
            }
        }
	}
}
