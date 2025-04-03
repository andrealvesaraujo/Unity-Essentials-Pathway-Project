using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("Duration of a full day in seconds")]
    [SerializeField] private float dayDuration = 60f; // Default: 60 seconds per full cycle

    private void Update()
    {
        if (dayDuration <= 0) return; // Prevent division by zero

        float rotationSpeed = 360f / dayDuration; // Degrees per second
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}
