using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rb : MonoBehaviour
{

    Rigidbody2D rib;
    float mov = 5f;

    void Start()
    {        

        rib = GetComponent<Rigidbody2D>();
        rib.gravityScale = (mov);


    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D bloque1)
    {
        if (bloque1.collider.CompareTag("bloque1"))
        {
            rib.gravityScale = (-mov);
        }
        if (bloque1.collider.CompareTag("bloque2"))
        {

            rib.gravityScale = (mov);

        }
        
    }
    


}
