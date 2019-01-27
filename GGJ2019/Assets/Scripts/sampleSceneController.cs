using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleSceneController : MonoBehaviour
{
    private StarGenerator starGenerator = new StarGenerator();
    private int numberOfStars;

    public static int minX = -500;
    public static int maxX = 500;
    public static int minY = -500;
    public static int maxY = 500;
    public static int minZ = -500;
    public static int maxZ = 500;


    // Start is called before the first frame update
    void Start()
    {
        PopulatePlayer();
        PopulateStars();
        AddCamera();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void PopulatePlayer()
    {
        GameObject player = Instantiate(Resources.Load("player", typeof(GameObject))) as GameObject;
    }

    private void PopulateStars()
    {
        numberOfStars = Random.Range(starGenerator.minNumberOfStars, starGenerator.maxNumberOfStars);
        starGenerator.SetUp(numberOfStars);
    }

    private void AddCamera()
    {
        GameObject player = Instantiate(Resources.Load("Main Camera", typeof(GameObject))) as GameObject;
    }
}
