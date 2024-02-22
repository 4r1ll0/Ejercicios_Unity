using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubo : MonoBehaviour
{
    public Vector3 ejex = new Vector3(4,0,0);
    private Vector3 puntoInicial = new Vector3(-5,0,0);


    public string direccion = "derecha";
    void Update()
    {
        // Calculamos direccion de movimiento
        if (transform.position.x >= ejex.x)
        {
            direccion = "izquierda";
            
        }
        else if(transform.position.x <= puntoInicial.x)
        {
            direccion = "derecha";
        }


        // Nos movemos
        if (direccion == "derecha")
        {
            transform.Translate(Vector3.right * Time.deltaTime);
        }
        else if (direccion == "izquierda")
        {
            // Nos movemos a la izquierda
            transform.Translate(Vector3.left * Time.deltaTime);
        }
    }
}