/*********************************************************
 * File: PlayerBehavior.cs
 * Author: Annabelle Ruckle
 * Purpose: For controlling the movement and rotation of out player gameobject in a 3D environment  
 * Due Date: Nov. 20, 2023
 * 
 * Contents of Code:
 * - Classes
 * - Functions
 * - If Statement 
 * 
 * Resources:
 *
 * https://www.youtube.com/watch?v=4HpC--2iowE
 * this resource helped me better understand and implement third person movement in 3D
 ************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public float moveSpeed = 10f;//player's movement speed
    public float rotateSpeed = 75f;//player's rotation speed
    private float vInput;//for vertical movement
    private float hInput;//for horizontal rotation
    private Rigidbody _rb;//player's Rigidbody component
    private CapsuleCollider _col;//player's CapsuleCollider component

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();//rigidbody component of the player
        _col = GetComponent<CapsuleCollider>();//CapsuleCollider component of the player
    }
    void Update()
    {
        vInput = Input.GetAxis("Vertical") * moveSpeed;  //get input for vertical movement
        hInput = Input.GetAxis("Horizontal") * rotateSpeed;//get input for horizontal rotation
    }
    private void FixedUpdate()
    {
        if (Mathf.Abs(hInput) > 0.01f)//checking if there is any horizontal input
        {
            Vector3 rotation = Vector3.up * hInput;//calculating the rotation vector
            Quaternion angleRot = Quaternion.Euler(rotation * Time.fixedDeltaTime);//calculating the rotation angle
            _rb.MoveRotation(_rb.rotation * angleRot);//rotating the player based on input
        }

        if (Mathf.Abs(vInput) > 0.01f)//checking if there is any vertical input
        {
            _rb.MovePosition(this.transform.position + this.transform.forward * vInput * Time.fixedDeltaTime);//moving the player based on input
        }
    }
}

