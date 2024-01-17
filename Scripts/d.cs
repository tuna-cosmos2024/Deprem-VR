using UnityEngine;

public class ObjectWithPoints : MonoBehaviour
{
    public int pointValue = 1; // Adjust the point value for each object

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with a specific object
        if (collision.gameObject.CompareTag("Bag"))
        {
            PointsBar pointsBar = FindObjectOfType<PointsBar>();
            if (pointsBar != null)
            {
                pointsBar.UpdatePoints(pointValue);
            }

            // Optionally, destroy the object after collision
            Destroy(gameObject);
        }
    }
}

