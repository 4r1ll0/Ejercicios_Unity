using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cuborojo : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 5f;
    float direcion;
    Vector2 mov = new Vector2(1, 0);


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        direcion = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(Vector2.right *direcion* speed * Time.deltaTime, ForceMode2D.Force);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("bloque3"))
        {
            direcion = -1;
        }
        else if (collision.collider.CompareTag("bloque4"))
        {
            direcion = 1;
        }
    }
}
