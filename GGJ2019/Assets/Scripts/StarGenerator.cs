using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarGenerator : MonoBehaviour
{
    public int minNumberOfStars = 3;
    public int maxNumberOfStars = 5;

    public int typesOfStar = 2;

    private PlanetGenerator planetGenerator = new PlanetGenerator();

    public void SetUp(int numberOfStars)
    {
        Debug.Log("About to populate " + numberOfStars + " stars !");

        int x;
        int z;
        int starType;

        for (int i = 0; i < numberOfStars; i++)
        {
            Debug.Log("Populate star: " + i);
            x = Random.Range(SampleSceneController.minX, SampleSceneController.maxX);
            z = Random.Range(SampleSceneController.minZ, SampleSceneController.maxZ);
            starType = Random.Range(0, typesOfStar);
            if (i == numberOfStars - 1)
            {
                addStar(x, z, starType, true);
            } else
            {
                addStar(x, z, starType, false);
            }
            
        }
    }

    private void addStar(int x, int z, int starType, bool lastone)
    {
        CelestialBody star;
        if (starType == 0)
        {
            star = Instantiate(Resources.Load<CelestialBody>("PS_BlueSun"));
        }
        else
        {
            star = Instantiate(Resources.Load<CelestialBody>("PS_Sun"));
        }
        star.transform.position = new Vector3(x, 0, z);

        int numberOfPlanets = Random.Range(planetGenerator.minNumberOfPlanets, planetGenerator.maxNumberOfPlanets);
        planetGenerator.SetUp(numberOfPlanets, star, lastone);
    }
}
