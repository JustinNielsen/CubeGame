using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

//Center = Menu, Right = Settings, Left = Customize Player, Down = Store, Up = Games
public enum Location { Center, Right, Left, Up, Down };

public class RotateCube : MonoBehaviour
{

    public Location location;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        location = Location.Center;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RotateRight()
    {
        anim.SetTrigger("Right");
        location = Location.Right;
    }

    public void RotateLeft()
    {
        anim.SetTrigger("Left");
        location = Location.Left;
    }

    public void RotateUp()
    {
        anim.SetTrigger("Up");
        location = Location.Up;
    }

    public void RotateDown()
    {
        anim.SetTrigger("Down");
        location = Location.Down;
    }

    public void Back()
    {
        switch (location)
        {
            case Location.Center:
                //Do Nothing
                break;
            case Location.Right:
                //Rotate Cube Left
                anim.SetTrigger("Left");
                break;
            case Location.Left:
                //Rotate Cube Right
                anim.SetTrigger("Right");
                break;
            case Location.Up:
                //Rotate cube Down
                anim.SetTrigger("Down");
                break;
            case Location.Down:
                //Rotate Cube Up
                anim.SetTrigger("Up");
                break;
        }

        //Set the location to center
        location = Location.Center;
    }
}
