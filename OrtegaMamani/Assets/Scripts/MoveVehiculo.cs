using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveVehiculo : MonoBehaviour
{
    public float speedZ;
    public int tipe;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (tipe==1)
        {   
            transform.Translate(0,0,speedZ);
            if (transform.position.z > 60)
            {
                Destroy(gameObject);
            }
        }
        if (tipe==2)
        {
            transform.Translate(0,0,speedZ);
            if (transform.position.x < -40)
            {
                Destroy(gameObject);
            }
        }
        if (tipe==3)
        {
            transform.Translate(0,0,speedZ);
            if (transform.position.x > 100)
            {
                Destroy(gameObject);
            }
        }
        if (tipe==4)
        {
            transform.Translate(0,0,speedZ);
            if (transform.position.z < -75)
            {
                Destroy(gameObject);
            }
        }
    }
}
