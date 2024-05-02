using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cuboazul : MonoBehaviour
{
    Vector2 mov = new Vector2(1, 0);
    public float speed = 4f;
    Rigidbody2D rb;
    float direction;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        direction = 1f;
        rb.AddForce(Vector2.right * speed,ForceMode2D.Impulse);
    }

    void Update()
    {
        rb.AddForce(Vector2.right * direction * speed * Time.deltaTime, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("bloque3"))
        {
            direction = -1;
           // rb.AddForce(Vector2.left * speed);
        }
        else if (collision.collider.CompareTag("bloque4"))
        {
            direction = 1;
            //rb.AddForce(Vector2.right * speed);
        }
    }
}
