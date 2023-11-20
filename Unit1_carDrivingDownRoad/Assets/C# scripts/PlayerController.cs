using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Private Variables
    //when you "public" smth you'll be able to see it and change it through unity. 
    //after finishing the game, we change all of these into private
    private float speed = 10.0f;
    private float turnSpeed = 25.0f; //if you dont set anything it would come out as zero
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start() //this void is already private so you don't have to write private
    {
        
    }

    // Update is called once per frame
    void Update() //this void is already private so you don't have to write private
    {   
        /*
        this line on the bottom is trying to get the axes we found in unity : 
        edit-> project settings -> Input Manager -> Axes ->Horizontal
        */
        //This is where we get player input.
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        /*
        //We move the tank forward here.
        x,y,z... we want to move forward so we have to move z
        transform.Translate(0,0,1); == transform.Translate(Vector3.forward);
        Time.deltaTime = now time (seconds) == 1 meter / sec.
        bottom line meaning in math == (0*time*20, 0*time*20, 1*time*20) == moving 20 meters /sec.
        20 is a random number == hard coded number
        */
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        /*
        line above can change turn speed and can use "a" and "d" ("left arrow " and "right arrow") to go left and right
        */

        //We turn the tank
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
        /*
        if we change the translate to rotate, our tank will now start to turn like a car, not just side by side
        we wrote "up" because the only thing changing when rotating is our y rotation
        */
    }
}
