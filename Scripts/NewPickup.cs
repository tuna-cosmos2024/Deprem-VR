using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPickup : MonoBehaviour
{
   [SerializeField] private LayerMask Pickuplayer;
   [SerializeField] private Camera Playercamera;
   [SerializeField] private float throwspeed;
   [SerializeField] private float PickupRange;
   [SerializeField] private Transform Hand;

   private Rigidbody CurrentObjectRigidbody;
   private Collider CurrentObjectCollider;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
          Ray PickupRay = new Ray(Playercamera.transform.position, Playercamera.transform.forward);

       if (Physics.Raycast(PickupRay, out RaycastHit hitInfo, PickupRange, Pickuplayer))
         {
             if(CurrentObjectRigidbody)
             {
            CurrentObjectRigidbody.isKinematic =false;
            CurrentObjectCollider.enabled = true;

            CurrentObjectRigidbody = hitInfo.rigidbody;
            CurrentObjectCollider = hitInfo.collider;

            
            CurrentObjectRigidbody.isKinematic =true;
            CurrentObjectCollider.enabled = false;


             }
             else
             {
            CurrentObjectRigidbody = hitInfo.rigidbody;
            CurrentObjectCollider = hitInfo.collider;

            CurrentObjectRigidbody.isKinematic =true;
            CurrentObjectCollider.enabled = false;
            }

            return;

          }
           if(CurrentObjectRigidbody)
             {
            CurrentObjectRigidbody.isKinematic =false;
            CurrentObjectCollider.enabled = true;

            CurrentObjectRigidbody = null;
            CurrentObjectCollider = null;
             }
        }

    if(Input.GetKeyDown(KeyCode.Q))
    {
        if(CurrentObjectRigidbody)
        {
            CurrentObjectRigidbody.isKinematic =false;
            CurrentObjectCollider.enabled = true;

            CurrentObjectRigidbody.AddForce(Playercamera.transform.forward * throwspeed, ForceMode.Impulse);

            CurrentObjectRigidbody = null;
            CurrentObjectCollider = null;

        }
    }
       
     if(CurrentObjectRigidbody)
     {
        CurrentObjectRigidbody.position = Hand.position;
        CurrentObjectRigidbody.rotation = Hand.rotation;
        
     }


    }
}
