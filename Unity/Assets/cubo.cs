using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubo : MonoBehaviour
{
    public Vector3 posicionFinal = new Vector3 (5,0,0); 
    public float speed = 5;

    void Update()
    {
        /*if (transform.position.x <= posicionFinal.x )
        {
            transform.Translate(movimiento * Time.deltaTime * speed);

        }*/

        /*Comparar la position actual del cubo con la posicion final a la que quieres llegar
         * Si ha llegado, cambiar de direccion
         * Si no ha llegado, moverse hacia esa dieccion
         * 
         * 

    }
}
