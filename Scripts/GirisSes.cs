using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirisSes : MonoBehaviour
{
    public AudioSource depremGiris;

    public float zaman = 0;



    // Start is called before the first frame update
    void Start()
    {
      
       
    }

    // Update is called once per frame
    void Update()
    {
        zaman += Time.deltaTime;


        if(zaman >= 15)
        {
            depremGiris.Play();
        }
    }
}
