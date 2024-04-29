using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fuerzayvelocidad : MonoBehaviour
{
    Rigidbody2D rb;
   public float speed = 10f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
                rb.AddForce(transform.right * speed);

    }
}
