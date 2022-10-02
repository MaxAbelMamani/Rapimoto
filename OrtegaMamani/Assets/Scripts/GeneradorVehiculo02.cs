using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorVehiculo02 : MonoBehaviour
{
    public GameObject vehiculo02;

    void Start()
    {
        InvokeRepeating("GenerateVehiculo", 0, 9);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateVehiculo()
    {
        Instantiate(vehiculo02, transform.position, transform.rotation);
    }
}
