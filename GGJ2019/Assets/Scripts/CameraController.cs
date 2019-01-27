using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.FindGameObjectsWithTag("Player")[0];
        transform.position = new Vector3(player.transform.position.x - 20, transform.position.y, player.transform.position.z + 140);
    }
}
