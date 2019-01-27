using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 20;

    public float speedBoost = 50;
    public float turnSpeed = 7;
    public float drag = 5;
    public float turnRadius = 3;

    public float landSpeedLimit = 20;
    public float damageSpeedLimit = 50;

    private float score = 0; 

    void Start()
    {
        GetComponent<Rigidbody>().drag = drag;
    }

    private void OnTriggerEnter(Collider other) {
        function1();
        //
        //
        //
        //
        //
        function2();
    }

    private void function1(){
        float velocity = GetComponent<Rigidbody>().velocity.magnitude;

        if (velocity < landSpeedLimit)
        {
            ScoreHolder.SetEndingMsg("Successfully landed on a new Planet!");
        }

        //update score
        ScoreHolder.SetScore(score);
        

        SceneManager.LoadScene("GameOverScene");

    }

    //
    //
    //
    //

    private void function2(){
        
    }

    void Update()
    {
        bool turning = false;

        float currentSpeed = speed;

        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) {
            currentSpeed = speed * speedBoost;
        }

        if (Input.GetKey(KeyCode.UpArrow)) {
            GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 0, -currentSpeed));
        }

        if (Input.GetKey(KeyCode.DownArrow)) {
            GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 0, currentSpeed));
        }

        if (Input.GetKey(KeyCode.LeftArrow)) {
            GetComponent<Rigidbody>().angularVelocity = new Vector3(0, -turnRadius, 0);
            GetComponent<Rigidbody>().AddRelativeForce(new Vector3(-turnSpeed, 0, 0));
            // if (true) {
            //     transform.Rotate(new Vector3(0, 0, 0.3f));
            // }
            turning = true;
        }

        if (Input.GetKey(KeyCode.RightArrow)) {
            GetComponent<Rigidbody>().angularVelocity = new Vector3(0, turnRadius, 0);
            GetComponent<Rigidbody>().AddRelativeForce(new Vector3(turnSpeed, 0, 0));
            // if (true) {
            //     transform.Rotate(new Vector3(0, 0, -0.3f));
            // }
            turning = true;
        }

        if(!turning) {
            GetComponent<Rigidbody>().angularVelocity = new Vector3(0, 0, 0);
        }

        // Vector3 currentPosition = GetComponent<Rigidbody>().transform.position;

        // GetComponent<Rigidbody>().transform.position = new Vector3(currentPosition.x, 0, currentPosition.z);

        //TODO: Code to update energy


        // Code to update score
        score += Time.deltaTime;

    }
}
