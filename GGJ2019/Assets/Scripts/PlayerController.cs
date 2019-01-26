using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20;
    public float turnSpeed = 7;
    public float drag = 5;
    public float turnRadius = 3;

    void Start()
    {
        GetComponent<Rigidbody>().drag = drag;
    }

    void Update()
    {
        bool turning = false;

        if (Input.GetKey(KeyCode.UpArrow)) {
            GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, speed, 0));
        }

        if (Input.GetKey(KeyCode.DownArrow)) {
            GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, -speed, 0));
        }

        if (Input.GetKey(KeyCode.LeftArrow)) {
            GetComponent<Rigidbody>().angularVelocity = new Vector3(0, 0, -turnRadius);
            GetComponent<Rigidbody>().AddRelativeForce(new Vector3(-turnSpeed, 0, 0));
            turning = true;
        }

        if (Input.GetKey(KeyCode.RightArrow)) {
            GetComponent<Rigidbody>().angularVelocity = new Vector3(0, 0, turnRadius);
            GetComponent<Rigidbody>().AddRelativeForce(new Vector3(turnSpeed, 0, 0));
            turning = true;
        }

        if(!turning) {
            GetComponent<Rigidbody>().angularVelocity = new Vector3(0, 0, 0);
        }
    }
}
