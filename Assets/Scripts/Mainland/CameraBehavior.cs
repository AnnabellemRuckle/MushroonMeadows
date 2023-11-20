/*********************************************************
 * File: CameraBehavior.cs
 * Author: Annabelle Ruckle
 * Purpose: Targets and follows the player 
 * Due Date: Nov. 20, 2023
 * 
 * Contents of Code:
 * - Classes
 * - Functions
 * 
 * Resources:
 *
 * https://www.youtube.com/watch?v=HVB6UVcb3f8&list=PLPV2KyIb3jR53Jce9hP7G5xC4O9AgnOuL&index=5
 * this resource helped me implement the camera's ability to offset and follow the player during tranform 
 ************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    //offset for positioning the camera relative to the player 
    public Vector3 camOffset = new Vector3(0, 1.2f, -2.6f); 
    private Transform target; 
    void Start() 
    {
        //assign the player's transform 
        target = GameObject.Find("Player").transform;
    } 
     //called after all update functions have been called
    void LateUpdate() 
    { 
        this.transform.position = target.TransformPoint(camOffset);//setting the camera's position to the transformed position 
        this.transform.LookAt(target);//making the camera look at the player 
    } 
}