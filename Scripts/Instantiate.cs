using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public GameObject fallinObject;
    public Transform point;

    public float emir = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnTime", 0f, emir);
    }

    // Update is called once per frame
    void spawnTime()
    {
        Instantiate(fallinObject, point.position, Quaternion.identity);
    }
}
