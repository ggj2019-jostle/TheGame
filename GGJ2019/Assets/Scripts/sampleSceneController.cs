using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sampleSceneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        populateGame();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void populateGame()
    {
        GameObject instance = Instantiate(Resources.Load("nicePlanet", typeof(GameObject))) as GameObject;
    }
}
