using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartSceneCanvas : MonoBehaviour
{
    [SerializeField]
    private Button startButton;
    [SerializeField]
    private Text buttonText;

    void Start()
    {
        startButton.onClick.AddListener(() => StartCoroutine(waitSoundFinishes()));
    }

    public void HandleClick()
    {
        Debug.Log("Start button clicked");
        SceneManager.LoadScene("SampleScene");
    }

    IEnumerator waitSoundFinishes()
    {
        var source = GameObject.FindGameObjectsWithTag("SFX")[0].GetComponent<AudioSource>();

        source.Play();
        yield return new WaitWhile(() => source.isPlaying);
        HandleClick();
    }

}
