using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    
    
    //public GameObject startButtonObject = game;
    public Canvas canvas;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<Button>();
       // startButton = gameObject.GetComponent<Button>();

        Debug.Log("to set start button text");
        //Text buttonText = startButton.GetComponent<Text>();
        //buttonText.text = "Start game";
        Debug.Log("Add click listener");
        //startButton.onClick.AddListener(StartGame);
        //startButton.transform.position = new Vector3(0, 0, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        
    }
}
