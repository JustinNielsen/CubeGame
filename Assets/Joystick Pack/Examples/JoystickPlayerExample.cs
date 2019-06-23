using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickPlayerExample : MonoBehaviour
{
    public float speed;
    public FloatingJoystick moveJoystick;
    public FloatingJoystick lookJoystick;
    public Rigidbody rb;
    public GameObject enemy;
    private Vector3 dir;

    private void Start()
    {
        
    }

    public void FixedUpdate()
    {
        //Movement
        Vector3 direction = Vector3.forward * moveJoystick.Vertical + Vector3.right * moveJoystick.Horizontal;
        rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);

        //Look     
        if(lookJoystick.Direction != Vector2.zero)
        {
            dir = lookJoystick.Direction;
        }

        float heading = Mathf.Atan2(dir.x, dir.y) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, heading, 0f);
    }
}