using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue {

	public string name;


    // the first one is minimual amount of the lines, the second one will be max
	[TextArea(1, 500)]
	public string[] sentences;

}
