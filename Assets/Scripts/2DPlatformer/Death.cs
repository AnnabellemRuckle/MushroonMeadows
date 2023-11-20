/*********************************************************
 * File: Death.cs
 * Author: Annabelle Ruckle
 * Purpose: Simulate the player dying when colliding with the spikes sprite 
 * Due Date: Nov. 20, 2023
 * 
 * Contents of Code:
 * - Classes
 * - Functions
 * 
 * Resources:
 * https://www.youtube.com/watch?v=xbWr8f_LHGY
 * this resource helped me trigger the player into a specified scene 
 * ScreenTransition.cs
 ************************************************************/
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public string LoadScene;//the name of the scene to load when the player collides with spikes

    //called when a Collider2D enters the trigger 
    void OnTriggerEnter2D()
    {
        //loading the scene when the player collides with the spikes
        SceneManager.LoadScene(LoadScene);
    }
}
