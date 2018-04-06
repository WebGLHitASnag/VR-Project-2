using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Used to manage scenes

public class MainMenu : MonoBehaviour {

    // This function will load a new scene (Level 1)
    public void LoadLevel1() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // This function will load a new scene (Level 2)
    public void LoadLevel2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2); // Super SIMPLE!
    }

    // This function will load a new scene (Leaderboard)
    public void LoadleaderBoard() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }

}
