using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim : MonoBehaviour
{
    public GameObject tik;

    

    public GameObject carpi;
    public float deltazaman = 2.0f;

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Bag"))
        {
            
            Destroy(gameObject);

    }

 
}

}
