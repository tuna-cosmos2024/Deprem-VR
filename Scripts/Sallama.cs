using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sallama : MonoBehaviour
{
    public float siddet;

    public float sure;

    public float gecenzaman;

    private Vector3 baslangic;

    public bool durum = false;

    float artis = 0.03f;


    public bool durum_2 = false;

    public float zama_2;

    public float zaman_3;


    // Start is called before the first frame update
    void Start()
    {
        baslangic = transform.position;

    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            durum_2 = true;
        }  

        if(durum_2)
        {
            zama_2 += Time.deltaTime;

            if(zama_2 >= 1f)
            {
                durum = true;
            }
        }









        
        if(durum)
        {
            siddet += Time.deltaTime;

            if(siddet >= 0.1f)
            {
                siddet = 0.1f;

                zaman_3 += Time.deltaTime;
            }


            if(zaman_3 > 65f)
            {
                siddet = 0f;
            }



           
            float fark_1 = Random.Range(-siddet, siddet);
            Vector3 fark = new Vector3(0, 0, fark_1);

            transform.position = baslangic + fark;

            gecenzaman += Time.deltaTime;

            fark_1 += artis * Time.deltaTime;


            



            
        }
        else
        {
            baslangic = transform.position;
            durum = false;

        }

        
    
    }
}
