using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float speed;

    Rigidbody rb;
    float horizontal;
    float vertical;
    Vector3 movement;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        movement = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        movement = new Vector3(horizontal, vertical, 0) * speed;
    }

    private void FixedUpdate()
    {
        this.transform.Translate(movement);
    }
}
