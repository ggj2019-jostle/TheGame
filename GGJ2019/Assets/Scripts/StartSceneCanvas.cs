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
<<<<<<< HEAD
    {
=======
    {
<<<<<<< HEAD
=======
        Debug.Log("Start button clicked");
        new WaitForSeconds(3);
>>>>>>> 3e2766cf30d042ee37e6fd48123a6fc7154248f4
        SceneManager.LoadScene("SampleScene");
>>>>>>> 238d6575f3b8c7a1b011687d13b6f2d963d3de25

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
