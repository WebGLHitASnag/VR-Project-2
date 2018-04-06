using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour {
    // This method will return the player to the Main Menu
    public void ReturnToMenu(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
}
