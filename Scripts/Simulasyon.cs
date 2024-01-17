using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simulasyon : MonoBehaviour
{

    public float geriSayim = 7.0f;
    public Animator LightAnim;
    
    // Start is called before the first frame update
    void Start()
    {
        LightAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
          if(Input.GetKeyDown(KeyCode.LeftShift))
        {
           Invoke("Simulator", geriSayim);
        }
    }

    void Simulator()
    {
       LightAnim.SetTrigger("Deprem");

    }
}
