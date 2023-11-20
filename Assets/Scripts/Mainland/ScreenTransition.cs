/*********************************************************
 * File: SceneTransition.cs
 * Author: Annabelle Ruckle
 * Purpose: Loads player into Mushroom Quest and Wack-a-Mushroom by collsion 
 * Due Date: Nov. 20, 2023
 * 
 * Contents of Code:
 * - Classes
 * - Functions
 * 
 * 
 * Resources:
 
 * https://www.youtube.com/watch?v=xbWr8f_LHGY
 * this resource helped me learn how to have a player collide with another object with a collider and trigger into a specified scene 
 ************************************************************/
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public string LoadScene;
    //this method is automatically called when the player gameobject with a collider enters the trigger zone
    void OnTriggerEnter()
    {
        //SceneManager.LoadScene loads the specified scene in the inspector 
        SceneManager.LoadScene(LoadScene);
    }

}
