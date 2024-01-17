using UnityEngine;

public class GyroCameraController : MonoBehaviour
{
    private bool gyroEnabled;
    private Gyroscope gyro;

    void Start()
    {
        // Check if the gyroscope is available on the device
        gyroEnabled = SystemInfo.supportsGyroscope;

        if (gyroEnabled)
        {
            gyro = Input.gyro;
            gyro.enabled = true;
        }
        else
        {
            Debug.LogWarning("Gyroscope not supported on this device.");
        }
    }

    void Update()
    {
        if (gyroEnabled)
        {
            // Rotate the camera based on the gyroscope input
            transform.Rotate(-gyro.rotationRateUnbiased.x, -gyro.rotationRateUnbiased.y, gyro.rotationRateUnbiased.z);
        }
    }
}
