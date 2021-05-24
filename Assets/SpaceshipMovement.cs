using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipMovement : MonoBehaviour
{
    private Transform myTransform;
    public int SpaceShipSpeed=4;

    //welcome message and instructions
    void Start()
    {
        print("Welcome to Space Shooter Game\nPress ← for shifting left\nPress → for shifting left\n Press Mouse left button for shooting asteroids\n");
        myTransform= transform;
        myTransform.position = new Vector3(2,2,-35);  //to give particular postion
    }



   
    // this code is for movement of spaceship to left and right
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow)) // checking for button press
        {
            transform.Translate(Vector3.left * SpaceShipSpeed); //to move left
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow)) // checking for button press
        {
            transform.Translate(Vector3.right * SpaceShipSpeed); //to move left
        }
    }
}
