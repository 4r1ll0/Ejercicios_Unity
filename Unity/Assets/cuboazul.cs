using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cuboazul : MonoBehaviour
{
    Vector2 mov = new Vector2(1, 0);
    public float speed = 4f;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
                transform.Translate(mov * Time.deltaTime * speed);

    }
}
