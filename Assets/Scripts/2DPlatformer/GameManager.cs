/*********************************************************
 * File: GameManager.cs
 * Author: Annabelle Ruckle
 * Purpose: Manages the game state, object collection, and scene transitions
 * Due Date: Nov. 20, 2023
 * 
 * Contents of Code:
 * - Classes
 * - Functions
 * - If Statements
 * 
 * Resources:
 * https://www.youtube.com/watch?v=GG0NYcOQd0k
 * This resource helped the implementation of keeping track of collectable while changing UI text 
 ************************************************************/
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int totalObjectsToCollect = 5;//number of objects the player needs to collect to win
    private int collectedObjects = 0;//counter for the collected objects
    private float currentCountdown;
    public GameObject endGameObject;//reference to the end game object
    public TMP_Text countdownText; 
    void Start()
    {
        //initialize collected objects and countdown
        collectedObjects = 0;
        currentCountdown = totalObjectsToCollect;
        UpdateCountdownText();
    }

    //method called when an object is collected
    public void CollectObject()
    {
        //increment the collected object count
        collectedObjects++;
        //checking if the player has collected all the objects
        if (collectedObjects == totalObjectsToCollect)
        {
            EndGame(true);//if true to indicate a win
        }
        else
        {
            //decrease the countdown with each collected object
            currentCountdown--;
            UpdateCountdownText();
            Debug.Log("Objects collected: " + collectedObjects);//debug to the console 
        }
    }

    //called when a Collider2D enters the trigger 
    void OnTriggerEnter2D(Collider2D other)
    {
        //checking if the entering object is the player and matches the endGameObject
        if (other.CompareTag("Player") && other.gameObject == endGameObject)
        {
            EndGame(false); //if false to indicate a loss
        }
    }
    //method updates the countdown text to display the remaining objects to collect
    void UpdateCountdownText()
    {
        countdownText.text = "COINS: " + Mathf.Ceil(currentCountdown).ToString();
    }
    //ends the game either if the player wins or loses
    void EndGame(bool isWin)
    {
        if (isWin)
        {
            Debug.Log("You Win!");//debug 
            countdownText.text = "YOU WIN!";
            float delay = 2f; //add a delay of 2 seconds before changing the scene
            Invoke("ChangeScene", delay);
        }
    }
    //changing the scene to "MainLand"
    void ChangeScene()
    {
        SceneManager.LoadScene("MainLand");
    }
}
