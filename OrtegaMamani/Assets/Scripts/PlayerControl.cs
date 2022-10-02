using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public GameObject Envio;
    public GameObject generador01;
    public GameObject Entrega;
    public GameObject generador02;
    public bool entrega;
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
    // Start is called before the first frame update

    void Start()
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
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Envio"))
        {
            Destroy(other.gameObject);
            Instantiate(Entrega, generador02.transform.position, generador02.transform.rotation);
        }
        if (other.CompareTag("Entrega"))
        {
            Destroy(other.gameObject);
            Instantiate(Envio, generador01.transform.position, generador01.transform.rotation);
      
        }
    }
}
