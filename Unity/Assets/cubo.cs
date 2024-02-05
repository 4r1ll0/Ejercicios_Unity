using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubo : MonoBehaviour
{
    //Vector2 direccionArriba = new Vector2(0, 10);
    public float speed = 5;
    void Update()
    {

        //transform.Translate(direccionArriba * speed * Time.deltaTime);
       transform.position = new Vector2(2, 0);

    }
}
