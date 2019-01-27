using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarGenerator : MonoBehaviour
{
    public int minNumberOfStars = 3;
    public int maxNumberOfStars = 7;

    private PlanetGenerator planetGenerator = new PlanetGenerator();

    public void SetUp(int numberOfStars)
    {
        Debug.Log("About to populate " + numberOfStars + " stars !");

        int x;
        int z;

        for (int i = 0; i < numberOfStars; i++)
        {
            Debug.Log("Populate star: " + i);
            x = Random.Range(SampleSceneController.minX, SampleSceneController.maxX);
            z = Random.Range(SampleSceneController.minZ, SampleSceneController.maxZ);
            addStar(x, z);
        }
    }

    private void addStar(int x, int z)
    {
        GameObject instance = Instantiate(Resources.Load("nicePlanet", typeof(GameObject))) as GameObject;
        instance.transform.position = new Vector3(x, 0, z);
    }
}
