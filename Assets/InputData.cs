using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public struct InputData
{
    //Basic Movement
    public float hMovement;
    public float vMovement;

    //Mouse rotation
    public float verticalMouse;
    public float horizontalMouse;

    //Extra movement
    public bool dash;
    public bool jump;

    public void getInput()
    {
        // Basic Movement
        hMovement = Input.GetAxis("Horizontal");
        vMovement = Input.GetAxis("Vertical");

        //Mouse/Joystick rotation
        verticalMouse = Input.GetAxis("Mouse Y");
        horizontalMouse = Input.GetAxis("Mouse X");

        //Extra Movement
        dash = Input.GetButton("Dash");
        jump = Input.GetButtonDown("Jump");
    }
}