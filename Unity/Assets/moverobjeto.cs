using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverobjeto : MonoBehaviour
{

    public Vector2 mov = new Vector2 (5,0);
    public Vector2 movDos = new Vector2(-5, 0);

    public bool movPrincipal = true;

    void Update()
    {

        if (movPrincipal == true)
        {
           
           transform.Translate(mov * Time.deltaTime);
            if (mov.x > 5)
            {
                transform.Translate(movDos * Time.deltaTime);
            }
            if (mov.x < -5)
            {
                transform.Translate(mov * Time.deltaTime);
            }

        }
        else if (movPrincipal == false)
        {

            transform.Translate(movDos * Time.deltaTime);
        }
    }
}


