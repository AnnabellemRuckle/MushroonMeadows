/*********************************************************
 * File: CameraMovement.cs
 * Author: Annabelle Ruckle
 * Purpose: Tranform camera to follow the player 
 * Due Date: Nov. 20, 2023
 * 
 * Contents of Code:
 * - Classes
 * - Functions
 * 
 * 
 * Resources:
 * 
 * https://www.youtube.com/watch?v=HVB6UVcb3f8&list=PLPV2KyIb3jR53Jce9hP7G5xC4O9AgnOuL&index=5
 * this resource helped me implement the camera's ability to offset and follow the player during tranform 
 * 
 * https://www.youtube.com/watch?v=FXqwunFQuao
 * this resource is referenced for the camera's transform based on the player movement 
 ************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraMovement : MonoBehaviour
{
    public Vector3 camOffset = new Vector3(0, 1.2f, -2.6f);//offset for the camera position in relation to the player
    private Transform target;//reference to the player's transform

    void Start() 
    {
        //finding and assigning the player's transform to the target variable
        target = GameObject.Find("Player").transform;
    } 
    void LateUpdate() 
    {
        //setting the camera position to the transformed position of the player plus the offset
        this.transform.position = target.TransformPoint(camOffset); 
        this.transform.LookAt(target); //making the camera look at the player
    } 
}
