using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getaxis : MonoBehaviour
{

    Rigidbody2D rb;
    public float velocidad;
    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float movX = Input.GetAxis("Horizontal");
        float movY = Input.GetAxis("Vertical");

        Debug.Log(movX + " " + movY);

        rb.velocity = new Vector2(movX, movY) * velocidad;
    }
}
