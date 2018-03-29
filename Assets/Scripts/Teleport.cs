using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour
{

    public GameObject TargetCube = null;

    public GameObject Player = null;

    private bool startTeleport = false;


    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Player.transform.position = TargetCube.transform.position;
    }
}