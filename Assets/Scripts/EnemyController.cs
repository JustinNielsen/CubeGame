using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    //Player obeject
    private GameObject player;

    //Movement speed of the enemy
    public float speed = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        //Get a reference to the player through the player tag
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Find the distance to the player
        Vector3 distanceToPlayerVector = player.transform.position - this.transform.position;
        float distanceToPlayer = distanceToPlayerVector.magnitude;

        //Look at the player
        this.transform.LookAt(player.transform);

        //Stop the enemy from getting too close to the player 
        if(distanceToPlayer > 3)
            this.transform.Translate(Vector3.forward * speed);
    }
}
