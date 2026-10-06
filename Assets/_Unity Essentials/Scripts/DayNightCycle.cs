using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("The total number of real-world seconds it takes for a full 24-hour day to pass.")]
    [SerializeField] private float dayLengthInSeconds = 120f;

    // A full rotation is 360 degrees
    private const float FullRotation = 360f;

    void Update()
    {
        // Avoid division by zero if someone sets the length to 0 in the Inspector
        if (dayLengthInSeconds <= 0f) return;

        // Calculate how many degrees to rotate this frame
        // 360 degrees divided by total seconds gives degrees per second
        float degreesPerSecond = FullRotation / dayLengthInSeconds;

        // Rotate the light around its local X-axis to simulate the sun rising and setting
        // Time.deltaTime ensures smooth, framerate-independent rotation
        transform.Rotate(Vector3.right * degreesPerSecond * Time.deltaTime);
    }
}

