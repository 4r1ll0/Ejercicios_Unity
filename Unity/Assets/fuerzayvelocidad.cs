using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fuerzayvelocidad : MonoBehaviour
{
    Rigidbody2D rb;
    float direction;
    public float speed = 10f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        direction = 1f;
        rb.AddForce(Vector2.right * speed);
    }

    void Update()
    {
        rb.AddForce(Vector2.right * direction * speed * Time.deltaTime);
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("bloque3"))
        {
            direction = -1;
            rb.AddForce(Vector2.left * speed);
        }
        else if (collision.collider.CompareTag("bloque4"))
        {
            direction = 1;
            rb.AddForce(Vector2.right * speed);
        }
    }
}
