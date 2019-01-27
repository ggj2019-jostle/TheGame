using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetGenerator : MonoBehaviour
{
    public int minNumberOfPlanets = 2;
    public int maxNumberOfPlanets = 7;

    public int minRFromSun = 20;
    public int maxRFromSun = 150;

    public int minTranslationSpeed = 10;
    public int maxTranslationSpeed = 100;
    public int minRotationSpeed = 20;
    public int maxRotationSpeed = 100;

    public int numOfPlanetTypes = 9;


    public void SetUp(int amountOfPlanets, CelestialBody star, bool ensureHabitat)
    {
        int r;
        int translationSpeed;
        int rotationSpeed;
        int planetType;
        bool haveHabitat = true;
        for (int i = 0; i < amountOfPlanets; i++)
        {
            Debug.Log("Populate planet: " + i);
            r = Random.Range(minRFromSun, maxRFromSun);
            translationSpeed = Random.Range(minTranslationSpeed, maxTranslationSpeed);
            rotationSpeed = Random.Range(minRotationSpeed, maxRotationSpeed);
            if (ensureHabitat && !haveHabitat && i == amountOfPlanets - 1)
            {
                planetType = 1;
            } else
            {
                planetType = Random.Range(1, numOfPlanetTypes + 1);
            }
            if (ensureHabitat)
            {
                if(planetType == 1)
                {
                    haveHabitat = true;
                }
                addPlanet(r, translationSpeed, rotationSpeed, star, planetType);
            }
            else
            {
                addPlanet(r, translationSpeed, rotationSpeed, star, planetType);
            }
        }
    }

    private void addPlanet(int r, int translationSpeed, int rotationSpeed, CelestialBody star, int planetType)
    {
        Debug.Log("Populate planet: R = " + r + " , sun: " + star);
        Vector3 starposition = star.transform.position;


        CelestialBody planet;

        switch (planetType)
        {
            case 1:
                planet = Instantiate(Resources.Load<CelestialBody>("nicePlanet"));
                break;
            case 2:
                planet = Instantiate(Resources.Load<CelestialBody>("nicePlanet"));
                break;
            case 3:
                planet = Instantiate(Resources.Load<CelestialBody>("nicePlanet"));
                break;
            case 4:
                planet = Instantiate(Resources.Load<CelestialBody>("nicePlanet"));
                break;
            case 5:
                planet = Instantiate(Resources.Load<CelestialBody>("nicePlanet"));
                break;
            case 6:
                planet = Instantiate(Resources.Load<CelestialBody>("nicePlanet"));
                break;
            case 7:
                planet = Instantiate(Resources.Load<CelestialBody>("nicePlanet"));
                break;
            case 8:
                planet = Instantiate(Resources.Load<CelestialBody>("nicePlanet"));
                break;
            case 9:
                planet = Instantiate(Resources.Load<CelestialBody>("nicePlanet"));
                break;
            default:
                planet = Instantiate(Resources.Load<CelestialBody>("nicePlanet"));
                break;
        }


        planet._star = star;
        planet.TranslationSpeed = translationSpeed;
        planet.RotationSpeed = rotationSpeed;

        int randPosition = Random.Range(0, 2);
        if (randPosition == 0)
        {
            planet.transform.position = new Vector3(starposition.x + r, 0, starposition.z);
        }
        else
        {
            planet.transform.position = new Vector3(starposition.x, 0, starposition.z + r);
        }
        
    }
}
