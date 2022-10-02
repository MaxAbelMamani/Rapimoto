using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorVehiculo03 : MonoBehaviour
{
    public GameObject vehiculo03;

    void Start()
    {
        InvokeRepeating("GenerateVehiculo", 0, 12);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateVehiculo()
    {
        Instantiate(vehiculo03, transform.position, transform.rotation);
    }
}
