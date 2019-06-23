using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    //Player movement speed
    public float speed;
    public FloatingJoystick moveJoystick;
    public FloatingJoystick lookJoystick;

    [SerializeField]
    float movementSmoothing;
    
    Rigidbody rb;
    float horizontal;
    float vertical;
    Vector3 movement;
    Vector2 velocity;
    Vector3 dir;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        movement = Vector3.zero;
        dir = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        //Get horizontal and vertical inputs
        horizontal = moveJoystick.Horizontal;
        vertical = moveJoystick.Vertical;
        
    }

    private void FixedUpdate()
    {
        Move();
        Look();
    }

    private void Move()
    {
        //Get the target velocity
        Vector2 targetVelocity = new Vector2((horizontal * speed * Time.deltaTime) * 10, (vertical * speed * Time.deltaTime) * 10);
        //Smooth the movement and apply it to the player
        rb.velocity = Vector2.SmoothDamp(rb.velocity, targetVelocity, ref velocity, movementSmoothing);
    }

    private void Look()
    {
        if (lookJoystick.Direction != Vector2.zero)
        {
            dir = lookJoystick.Direction;
        }

        float heading = Mathf.Atan2(dir.x, dir.y) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, -heading);
    }
}
