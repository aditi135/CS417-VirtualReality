using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    private Light light;  // reference to the Light component

    void Start()
    {
        // Get the Light component attached to this GameObject
        light = GetComponent<Light>();

    }

    void Update()
    {
        // Check if the Space key was pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Change the color to a random color
            light.color = new Color(Random.value, Random.value, Random.value);

            // OR switch between two colors:
            // light.color = light.color == Color.white ? Color.red : Color.white;
        }
    }
}
