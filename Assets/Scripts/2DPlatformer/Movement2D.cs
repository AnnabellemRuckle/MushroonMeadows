/*********************************************************
 * File: Movement2D.cs
 * Author: Annabelle Ruckle
 * Purpose: Implement physics and sprite movement based on key input 
 * Due Date: Nov. 20, 2023
 * 
 * Contents of Code:
 * - Classes
 * - Functions
 * - If Statements
 * 
 * Resources:
 * 
 * https://www.youtube.com/watch?v=K1xZ-rycYY8&t=36s
 * this resource is the main contibution in my understanding and implementation of 2D movement 
 * https://docs.unity3d.com/ScriptReference/Vector2.html
 * vector 2 functionality 
 * https://docs.unity3d.com/ScriptReference/Input.GetKeyDown.html
 * this resource helped with the implementation of user input Getkey GetKeyDown
 ************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2D : MonoBehaviour
{
    //declaring public variables to control player movement and jumping
    public float moveSpeed = 5f;//sets the players movement speed
    public float jumpForce = 7f;//sets the force applied when the player jumps
    private bool isJumping = false;//keeps track of whether the player is currently jumping
    private Rigidbody2D rb;//reference to the players physics component
    private void Start()
    {
        //referencing the players rigidbody component
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        //handling player input for movement
        float moveX = 0f;//initialize a variable to control horizontal movement

        //checking if the 'a' key or 'left' arrow key is pressed and set the movement direction to left
        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            moveX = -1f;
        }
        //checking if the 'd' key or 'right' arrow key is pressed and set the movement direction to right
        else if (Input.GetKey("d") || Input.GetKey("right"))
        {
            moveX = 1f;
        }
        Vector2 movement = new Vector2(moveX * moveSpeed, rb.velocity.y);//creating a vector to represent the player's movement
        rb.velocity = movement;//applying the calculated movement to the player's rigidbody2D component

        //checking for jump input and make sure the player is not already jumping
        if ((Input.GetKeyDown("w") || Input.GetKeyDown("up")) && !isJumping)
        {
            //applying an upward force to make the player jump
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);//https://docs.unity3d.com/ScriptReference/Vector2.html
            isJumping = true;//marking the player as jumping to prevent continuous jumping
        }
    }
    //called when the player collides with other objects in the 2D physics system
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //checking if the player has collided with an object tagged as "Ground"
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;//marking the player as no longer jumping, as they are now on the ground
        }
    }
}
