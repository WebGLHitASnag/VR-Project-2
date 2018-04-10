using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnderWater : MonoBehaviour {

    public GameObject lakeWater;
    public GameObject riverWater;
    public GameObject oceanWater;
    private bool isUnderWater;
    private Color normalColor;
    private Color underWaterColor;

	void Start () {
        normalColor = new Color(0.5f, 0.5f, 0.5f, 0.5f);
        underWaterColor = new Color(0.22f, 0.65f, 0.77f, 0.5f);
    }
	
	void Update () {
        if (transform.position.x >= 4663.53 && transform.position.x <= 5061.121 && transform.position.z >= -729.498 && transform.position.z <= -331.1509) {
            if ((transform.position.y <= lakeWater.transform.position.y - 1) != isUnderWater) {
                isUnderWater = transform.position.y < lakeWater.transform.position.y - 1;
                if (isUnderWater) {
                    setUnderWater();
                }
                if (!isUnderWater) {
                    setNormal();
                }
            }
        }
        
        if (transform.position.x >= 345.55 && transform.position.x <= 638.3987 && transform.position.z >= -617.4688 && transform.position.z <= -320.8628) {
            if ((transform.position.y <= riverWater.transform.position.y - 1) != isUnderWater) {
                isUnderWater = transform.position.y < riverWater.transform.position.y - 1;
                if (isUnderWater) {
                    setUnderWater();
                }
                if (!isUnderWater) {
                    setNormal();
                }
            }
        }
        
        if (transform.position.x >= 58.27055 && transform.position.x <= 655.674 && transform.position.z >= 3856.067 && transform.position.z <= 4453.523) {
            if ((transform.position.y <= oceanWater.transform.position.y - 1) != isUnderWater) {
                isUnderWater = transform.position.y < oceanWater.transform.position.y - 1;
                if (isUnderWater) {
                    setUnderWater();
                }
                if (!isUnderWater) {
                    setNormal();
                }
            }
        }
    }

    public void setNormal() {
        RenderSettings.fogColor = normalColor;
        RenderSettings.fogDensity = 0.001f;
        Physics.gravity = new Vector3(0.0f, -9.81f, 0.0f);
    }

    public void setUnderWater() {
        RenderSettings.fogColor = underWaterColor;
        RenderSettings.fogDensity = 0.03f;
        Physics.gravity = new Vector3(0.0f, -2.5f, 0.0f);
    }
}
