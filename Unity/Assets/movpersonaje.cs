using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movpersonaje : MonoBehaviour
{
    public float speed = 10f;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float movX = Input.GetAxis("Horizontal") * speed;
        rb.velocity = new Vector2(movX, rb.velocity.y);

        bool salta = Input.GetButton("Jump");
        if (salta)
        {
            rb.AddForce(Vector2.up * speed);

        }
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //si choco con el trampolin...
       
        if (collision.collider.CompareTag("trampolin"))
        {
             Debug.Log(collision.collider.tag);

            rb.AddForce(Vector2.up * 1000);
        }
        
        
        //..tendré q aplicar una fuerza hacuia arriba, como el sal to
    }
}
