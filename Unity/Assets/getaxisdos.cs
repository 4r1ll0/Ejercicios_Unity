using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getaxisdos : MonoBehaviour
{

    void Update()
    {
       /* bool seAgranda = Input.GetButtonDown("Jump");
        if (seAgranda)
        {
            transform.localScale = new Vector3(2, 2, 0);
        }
        bool decrese = Input.GetButtonUp("Jump");
        if(decrese)
        {
            transform.localScale = new Vector3(1, 1, 0);
        }*/

        bool rota = Input.GetButton("Jump");
        if (rota)
        {
            transform.Rotate(Vector3.forward, Time.deltaTime * 360);
        }
        bool decrese = Input.GetKey(KeyCode.A);
        if (decrese)
        {
            transform.Rotate(Vector3.forward, Time.deltaTime * -360);
        }

    }
}
