using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartSceneCanvas: MonoBehaviour
{
    [SerializeField]
    private Button startButton;
    [SerializeField]
    private Text buttonText;

    void Start()
    {
        startButton.onClick.AddListener(HandleClick);
    }

    public void HandleClick()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
