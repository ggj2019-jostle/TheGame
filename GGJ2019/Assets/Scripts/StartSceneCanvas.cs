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
<<<<<<< HEAD
=======
        Debug.Log("Start button clicked");
        new WaitForSeconds(3);
>>>>>>> 3e2766cf30d042ee37e6fd48123a6fc7154248f4
        SceneManager.LoadScene("SampleScene");

    }

}
