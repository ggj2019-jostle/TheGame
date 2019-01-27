using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetGenerator : MonoBehaviour
{
    public int minNumberOfPlanets = 2;
    public int maxNumberOfPlanets = 7;

    public int minRFromSun = 20;
    public int maxRFromSun = 150;

    public int minSpeed = 10;
    public int maxSpeed = 100;

    public void SetUp(int amountOfPlanets, CelestialBody star)
    {

        for (int i = 0; i < amountOfPlanets; i++)
        {
            Debug.Log("Populate planet: " + i);
            int r = Random.Range(minRFromSun, maxRFromSun);
            int s = Random.Range(minSpeed, maxSpeed);
            addPlanet(r, s, star);
        }
    }

    private void addPlanet(int r, int speed, CelestialBody sun)
    {
        Debug.Log("Populate planet: R = " + r + " , sun: " + sun);
        Vector3 sunPosition = sun.transform.position;
  
        CelestialBody planet = Instantiate(Resources.Load<CelestialBody>("nicePlanet"));
        planet._star = sun;
        planet.TranslationSpeed = speed;

        int randPosition = Random.Range(0, 2);
        if (randPosition == 0)
        {
            planet.transform.position = new Vector3(sunPosition.x + r, 0, sunPosition.z);
        }
        else
        {
            planet.transform.position = new Vector3(sunPosition.x, 0, sunPosition.z + r);
        }
        
    }
}
