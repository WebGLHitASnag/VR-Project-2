using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour {

    // When the Quit text is clicked, terminate the application
    public void TerminateGame()
    {
        Debug.Log("Application Terminated");
        Application.Quit();
    }
}
