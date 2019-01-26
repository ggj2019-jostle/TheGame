using UnityEngine;

public class CelestialBody : MonoBehaviour
{
    // For all the int values the reference is our Sun which would be equals to 1

    public bool fixedBody = true;
    public GameObject star;

    public int translationSpeed = 10;
    public int rotationSpeed = 10;
    private float timecounter = 0;

    public CelestialBody(Color color, int temperature, float mass, float radius, float luminosity)
    {
        this.color = color;
        this.temperature = temperature;
        this.mass = mass;
        this.radius = radius;
        this.luminosity = luminosity;
    }

    public Color color { get; }
    public int temperature { get; }
    public float mass { get; }
    public float radius { get; }
    public float luminosity { get; }

    private void applyTranlation()
    {
        if (star != null)
        {
            float speed = timecounter * translationSpeed / 100;

            float R2x = Mathf.Pow(transform.position.x - star.transform.position.x, 2);
            float R2y = Mathf.Pow(transform.position.y - star.transform.position.y, 2);
            float R2z = Mathf.Pow(transform.position.z - star.transform.position.z, 2);

            float R = Mathf.Sqrt(R2x + R2y + R2z);

            float x = Mathf.Cos(speed) * R;
            float y = 0;
            float z = Mathf.Sin(speed) * R;

            transform.position = new Vector3(x, y, z);
        }
    }

    private void applyRotation()
    {

        transform.Rotate(new Vector3(0, -1, 0), rotationSpeed * Time.deltaTime);
    }

    private void applyGravity() {

    }

    private void FixedUpdate()
    {
        timecounter += Time.deltaTime;
        applyTranlation();
        applyRotation();
        applyGravity();
    }

}