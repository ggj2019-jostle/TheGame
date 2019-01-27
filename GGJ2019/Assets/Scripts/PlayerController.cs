using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20;

    public float speedBoost = 50;
    public float turnSpeed = 7;
    public float drag = 5;
    public float turnRadius = 3;

    void Start()
    {
        GetComponent<Rigidbody>().drag = drag;
    }

    void OnCollisionEnter(Collision collision) {
        Debug.Log("collision");
        GetComponent<Rigidbody>().velocity = -GetComponent<Rigidbody>().velocity;
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
    }
}
