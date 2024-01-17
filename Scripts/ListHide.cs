using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hide2 : MonoBehaviour
{
    public GameObject liste;
    public bool list = false;

    public GameObject panel;
    void Update()
    {
        if(Input.GetButtonDown("duru"))
        {
            panel.SetActive(false);

            list = !list;

            if(! list)
            {
                liste.SetActive(false);
            }

            if(list)
            {
                liste.SetActive(true);

            }
            
           
        }
    }
}
