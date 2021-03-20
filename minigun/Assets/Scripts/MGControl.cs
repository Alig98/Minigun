using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MGControl : MonoBehaviour
{
    public Transform spinningThing;
    float rotSpeed = 100;
    void Update()
    {
        spinningThing.Rotate(0, 10, 0);
        if (Input.GetMouseButton(0))
        {
            transform.Rotate(new Vector3(0, -Input.GetAxis("Mouse X"), -Input.GetAxis("Mouse Y")) * Time.deltaTime * rotSpeed);
        }


    }

}
