using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScSoga : MonoBehaviour
{
    public Vector3 fuerzaPrueba;
   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
            transform.GetChild(transform.childCount - 1).GetComponent<Rigidbody>().AddForce(fuerzaPrueba, ForceMode.Impulse);
        if (Input.GetKeyDown(KeyCode.O))
            transform.GetChild(transform.childCount / 2).GetComponent<Rigidbody>().AddForce(fuerzaPrueba, ForceMode.Impulse);
    }
}
