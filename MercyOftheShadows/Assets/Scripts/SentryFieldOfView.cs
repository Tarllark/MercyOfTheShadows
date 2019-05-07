using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SentryFieldOfView : MonoBehaviour
{

    GameObject player;
    public int fieldOfView = 2;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("player");
    }

    // Update is called once per frame
    void Update()
    {
        spotPlayer();
    }

    void spotPlayer()
    {
        Vector3 targetDir = player.transform.position - transform.position;
        Vector3 forward = transform.TransformDirection(Vector3.forward);

        if (Vector3.Dot(forward, targetDir) > fieldOfView)
        {
            Debug.Log("Spotted player");
        }

    }
}
