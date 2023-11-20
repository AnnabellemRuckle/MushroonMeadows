/*********************************************************
 * File: Collectables.cs
 * Author: Annabelle Ruckle 
 * Purpose: Player's ability to collide and collect coins 
 * Due Date: Nov. 20, 2023
 * 
 * Contents of Code:
 * - Classes
 * - Functions
 * - If Statements
 * 
 * Resources:
 * 
 * https://www.youtube.com/watch?v=5GWRPwuWtsQ
 * resource used for colliding and destroying the sprite coin gameobject 
 ************************************************************/
using UnityEngine;

public class Collectables : MonoBehaviour
{
    public GameManager gameManager;//reference to the GameManager script
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            gameManager.CollectObject();//notifying the GameManager that the item has been collected
            gameObject.SetActive(false);//destroying the collected item 
        }
    }
}
