using UnityEngine;

public class ObjectWithPoints : MonoBehaviour
{
    public int pointValue = 1; 
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Bag"))
        {
            
            PointsBar pointsBar = FindObjectOfType<PointsBar>();
            if (pointsBar != null)
            {
                pointsBar.UpdatePoints(pointValue);

               
            }

           
                  
           
            Destroy(gameObject);
            
        }
    }

    void Start()
    {
        
    }
}

