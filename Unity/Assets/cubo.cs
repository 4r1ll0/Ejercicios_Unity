using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubo : MonoBehaviour
{
    public Vector3 ejex = new Vector3(5,0);

    void Update()
    {
        transform.Translate(ejex * Time.deltaTime);


    }
}