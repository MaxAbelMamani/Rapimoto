using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    public int typeofGenerator;
    public GameObject generador02;
    public GameObject Entrega;
    private bool Capturado;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
   /* private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        switch (typeofGenerator)
        {
            case 1:
                Instantiate(Entrega, generador02.transform.position, generador02.transform.rotation);
                break;
        }
    }*/
    
}
