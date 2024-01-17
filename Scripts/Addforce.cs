using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addforce : MonoBehaviour
{
    public Rigidbody r;

    public float deger;

    private float zaman;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            zaman += Time.deltaTime;

            if(zaman > 7.0f)
            {
                r.AddForce(Vector3.forward * deger);
            }
        }


        if(Input.GetKeyDown(KeyCode.X))
        {
            Time.timeScale = 0.0f;
        }
    }
}
