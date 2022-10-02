using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorVehiculo01 : MonoBehaviour
{
    public GameObject vehiculo01;

    void Start()
    {
        InvokeRepeating("GenerateVehiculo", 0, 6);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateVehiculo()
    {
        Instantiate(vehiculo01, transform.position, transform.rotation);
    }
}
