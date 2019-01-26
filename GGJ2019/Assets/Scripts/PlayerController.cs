using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    GameObject ship;
    GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        //ship = GetComponent<GameObject>();
        cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.AddComponent<Rigidbody>();
        cube.GetComponent<Rigidbody>().useGravity = false;
        //cube.AddComponent<BoxCollider>();
        cube.transform.position = new Vector3(0, 0, 3);
        cube.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -60));
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.forward);
    }
}
