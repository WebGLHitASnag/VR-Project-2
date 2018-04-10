using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Used to manage scenes
using UnityEngine.UI;

public class LoadMainMenu : MonoBehaviour {

    public Image i_Fader;
    public static float alpha = .000000000000000000001f;
    void Start() {
        /*
        // Fetch image
        i_Fader = GetComponentInChildren<Image>();
        alpha = i_Fader.color.a;

        // Make sure material is reset
        i_Fader.material.SetColor("_Color", new Color(1, 1, 1, 0));*/
    }

    void Update() {

        /*// When the animation is done fade the video out
        if (Time.time > 4)
        {
            Debug.Log(i_Fader.material.GetColor("_Color"));
            i_Fader.material.SetColor("_Color", new Color(1, 1, 1, alpha));
            alpha += .000000000000000000001f;
        }*/

        // When fading is complete, load the main menu
        if (Time.time > 4) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
	
}