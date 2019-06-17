using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    //Player movement speed
    public float speed;

    [SerializeField]
    float movementSmoothing;
    
    Rigidbody rb;
    float horizontal;
    float vertical;
    Vector3 movement;
    Vector2 velocity;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        movement = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        //Get horizontal and vertical inputs
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        //movement = new Vector3(horizontal, vertical, 0) * speed;
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        //Get the target velocity
        Vector2 targetVelocity = new Vector2((horizontal * speed * Time.deltaTime) * 10, (vertical * speed * Time.deltaTime) * 10);
        //Smooth the movement and apply it to the player
        rb.velocity = Vector2.SmoothDamp(rb.velocity, targetVelocity, ref velocity, movementSmoothing);
    }
}
