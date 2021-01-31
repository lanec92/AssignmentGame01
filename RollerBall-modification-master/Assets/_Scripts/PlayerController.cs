using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; // may not be necessary
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed = 800.0f;
    public Text scoreText;
    public Text winText;
    //private int count = 0; // we now use keepData score

    private void Awake()
    {
        if (KeepData.OversizedBall)
        {
            this.gameObject.transform.localScale = new Vector3(3.0f, 3.0f, 3.0f);
            Debug.Log("oversized ball: " + KeepData.OversizedBall);
        }
        else
            this.gameObject.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
         
    }
    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");// capitalization matters
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        //GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);
        GetComponent<Rigidbody>().AddForce(movement * speed * KeepData.PlayerSpeedMultiplier * Time.deltaTime);
        //rigidbody refers to the rigidbody component that the script is attached to
        // addforce makes the object with the rigidbody move

    }
    private void OnTriggerEnter(Collider other) // when the ball/player enters a trigger collider
    {
        if(other.gameObject.tag == "Pickup") // if the object has a tag of "Pickup"
        {
            other.gameObject.SetActive(false); // set the object inactive - hide it.
            //count += 1; // count increases each time we pick up a cube
            KeepData.Currentscore += 1;
            //scoreText.text = "Score: " + count; //updates the score on the text field
            scoreText.text = KeepData.PlayerName + ": " + KeepData.Currentscore + "(High score: " + KeepData.HighScore + ")"; //updates the score on the text field
            if (KeepData.Currentscore > KeepData.HighScore) // do we have a new high score?
            {
                KeepData.HighScore = KeepData.Currentscore;
            }
            if (KeepData.Currentscore % 8 == 0)// did we get all targets?
            {
                winText.gameObject.SetActive(true);
                winText.text = "You got them all";
            }

        }
    }
}
