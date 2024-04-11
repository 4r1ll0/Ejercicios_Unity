using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getaxis : MonoBehaviour
{
    
  
    float speed = 10f;
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float movX = Input.GetAxis("Horizontal") * speed;
        float movY = Input.GetAxis("Vertical") * speed;
        rb.velocity = new Vector2(movX, movY);
        Debug.Log("se  mueve" + movX);


    }
}
