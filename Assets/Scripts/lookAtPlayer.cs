using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookAtPlayer : MonoBehaviour
{

    public GameObject player;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.LookAt(player.transform);
    }
}
