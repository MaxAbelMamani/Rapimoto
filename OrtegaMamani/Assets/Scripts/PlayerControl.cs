using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    //VARIABLES DE MANEJO
    //VELOCIDAD DEL VEHICULO
    public float speed = 5.0f;
    //VELOCIDAD DE GIRO
    public float turnSpeed = 0.0f;
    //MOVER EL VEHICULO DE DERECHA A IZQUIERDA
    public float horizontalInput;
    public float forwardInput;

    //Variables de Camara
    public Camera mainCamera;

    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //ASIGNACION CONFIGURACIONES DEL TECLADO
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //MOVER EL VEHICULO HACIA ADELANTE
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Time.deltaTime controla el intervalo de tiempo entre fotogramas
        //Modificar el giro
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        // transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
