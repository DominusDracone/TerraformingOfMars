using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MarsScript : MonoBehaviour
{
    // Start is called before the first frame update\
    public float rotacija = 0.3f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotacija + Time.deltaTime, 0);
    }
}
