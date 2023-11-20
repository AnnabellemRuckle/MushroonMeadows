/*********************************************************
 * File: Menu.cs
 * Author: Annabelle Ruckle
 * Purpose: Load player into main scene  
 * Due Date: Nov. 20, 2023
 * 
 * Contents of Code:
 * - Classes
 * - Functions
 * 
 * 
 * Resources:
 * https://www.youtube.com/watch?v=TAGZxRMloyU
 * this resource helped me learn how to work with UI buttons that can transition the player to the next scene using the build index 
 ************************************************************/
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    //this method is called when the "Play" button is pressed in the menu scene
    public void StartGame ()
    {
        //SceneManager.LoadScene loads the next scene in the build index
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //GetActiveScene().buildIndex gets the index of the currently active scene
    }
}
