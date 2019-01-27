using System;
using UnityEngine;

public class CelestialBody : MonoBehaviour
{
    // For all the int values the reference is our Sun which would be equals to 1

    public GameObject _star;
    private Rigidbody rb;

    public int TranslationSpeed;
    public int RotationSpeed;

    private GameObject player;
    private float Timecounter;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        TranslationSpeed = TranslationSpeed == null ? 10 : TranslationSpeed;
        RotationSpeed = RotationSpeed == null ? 10 : RotationSpeed;

        Timecounter = 0;

        player = GameObject.FindGameObjectsWithTag("Player")[0];
    }

    public CelestialBody(int temperature, float mass, float radius, float luminosity)
    {
        this.Temperature = temperature;
        this.Mass = mass;
        this.Radius = radius;
        this.Luminosity = luminosity;
    }

    public int Temperature { get; }
    public float Mass { get; }
    public float Radius { get; }
    public float Luminosity { get; }
    public Rigidbody Rb { get => rb; }

    private void ApplyTranslation()
    {
        if (_star != null)
        {
            float speed = Timecounter * TranslationSpeed / 100;

            float R2x = Mathf.Pow(transform.position.x - _star.transform.position.x, 2);
            float R2y = Mathf.Pow(transform.position.y - _star.transform.position.y, 2);
            float R2z = Mathf.Pow(transform.position.z - _star.transform.position.z, 2);

            float R = Mathf.Sqrt(R2x + R2y + R2z);

            float x = Mathf.Cos(speed) * R;
            float y = 0;
            float z = Mathf.Sin(speed) * R;

            transform.position = new Vector3(x, y, z);
        }
    }

    private void ApplyRotation()
    {

        transform.Rotate(new Vector3(0, -1, 0), RotationSpeed * Time.deltaTime);
    }

    private void ApplyGravity()
    {
        Rigidbody player_rb = player.GetComponent<Rigidbody>();

        Vector3 distance = player_rb.position - rb.position;
        float distanceMagnitude = distance.magnitude;


        if (Mathf.Pow(distanceMagnitude, -2) < 0.1)
            return;


        float forceMagnitute = Constants.GRAVITACIONAL * (rb.mass * player_rb.mass) / Mathf.Pow(distanceMagnitude, 2);
        Vector3 force = distance.normalized * forceMagnitute;

        player_rb.AddForce(-force);
    }


    private void FixedUpdate()
    {
        Timecounter += Time.deltaTime;
        ApplyTranslation();
        ApplyRotation();
        ApplyGravity();
    }


}