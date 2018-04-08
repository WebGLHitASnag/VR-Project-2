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
        if (startTeleport)
        {
            Player.transform.position = Vector3.Slerp(Player.transform.position, TargetCube.transform.position, 0.05f * Time.timeScale);
            float distance = Vector3.Distance(Player.transform.position, TargetCube.transform.position);
            if (distance < 3.0f)
            {
                startTeleport = false;
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        startTeleport = true;
    }
}
