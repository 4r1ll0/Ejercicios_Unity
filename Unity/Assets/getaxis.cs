using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getaxis : MonoBehaviour
{
    
  
    public float speed = 10f;
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //aqui se mueve el personaje
        float movX = Input.GetAxis("Horizontal") * speed;
        float movY = Input.GetAxis("Vertical") * speed;
        rb.velocity = new Vector2(movX, movY);
        Debug.Log("se  mueve" + movX);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // entro en el barro
        if (collision.CompareTag ("barro"))
        {
            speed = 5f;

        }
        // reducir velocidad en 2
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        // vuelve speed a la normalid
        if (collision.CompareTag("barro"))
        {
            speed = 10f;

        }
        // aumenar velocidad en 2
    }
}
