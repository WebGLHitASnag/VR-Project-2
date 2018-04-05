using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenGitHub : MonoBehaviour {

    // When the GitHub logo is clicked on the menu, open our repository
    public void OpenRepository() {
        Application.OpenURL("https://github.com/WebGLHitASnag/VR-Project-2");
    }
}
