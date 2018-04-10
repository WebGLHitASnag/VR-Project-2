using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitGame : MonoBehaviour {

    // When the Quit text is clicked, terminate the application
    public void TerminateGame()
    {
        Debug.Log("Application Terminated");
        Application.Quit();
    }

    public void ExitLevel2() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);

    }
}
