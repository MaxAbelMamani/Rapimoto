using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorVehiculo04 : MonoBehaviour
{
    public GameObject vehiculo04;

    void Start()
    {
        InvokeRepeating("GenerateVehiculo", 0, 15);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateVehiculo()
    {
        Instantiate(vehiculo04, transform.position, transform.rotation);
    }
}
