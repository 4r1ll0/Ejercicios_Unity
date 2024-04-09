using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getaxis : MonoBehaviour
{
    Vector2 movX = new Vector2(5, 0);
    Vector2 movY = new Vector2(0, 5);


    void Update()
    {
        float movX = Input.GetAxis("Horizontal");
        float movY = Input.GetAxis("Vertical");

    }
}
