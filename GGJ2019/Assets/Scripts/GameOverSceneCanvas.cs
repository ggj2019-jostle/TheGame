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
        exitButton.onClick.AddListener(() => StartCoroutine(ExitGame()));
        restartButton.onClick.AddListener(() => StartCoroutine(GoToStartScene()));
    }

    IEnumerator ExitGame()
    {

        var source = GameObject.FindGameObjectsWithTag("SFX")[0].GetComponent<AudioSource>();

        source.Play();
        yield return new WaitWhile(() => source.isPlaying);

        Debug.Log("Exit button clicked");
        endingMsg.text = "Thank you ~";
        scoreMsg.enabled = false;
        restartButton.interactable = false;
        exitButton.interactable = false;
    }

    IEnumerator GoToStartScene()
    {
        var source = GameObject.FindGameObjectsWithTag("SFX")[0].GetComponent<AudioSource>();

        source.Play();
        yield return new WaitWhile(() => source.isPlaying);

        Debug.Log("Restart button clicked");
        SceneManager.LoadScene("StartScene");
    }

}
