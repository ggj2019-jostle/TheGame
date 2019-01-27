using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverSceneCanvas : MonoBehaviour
{
    [SerializeField]
    private Button exitButton;
    [SerializeField]
    private Button restartButton;
    [SerializeField]
    private Text endingMsg;
    [SerializeField]
    private Text scoreMsg;

    // Start is called before the first frame update
    void Start()
    {
        endingMsg.text = ScoreHolder.GetEndingMsg();
        scoreMsg.text = "Your Score: " + ScoreHolder.GetThisRoundScore();
        exitButton.onClick.AddListener(ExitGame);
        restartButton.onClick.AddListener(GoToStartScene);
    }

    void ExitGame()
    {
        Debug.Log("Exit button clicked");
        endingMsg.text = "Thank you ~";
        scoreMsg.enabled = false;
        restartButton.interactable = false;
        exitButton.interactable = false;
    }

    void GoToStartScene()
    {
        Debug.Log("Restart button clicked");
        SceneManager.LoadScene("StartScene");
    }
}
