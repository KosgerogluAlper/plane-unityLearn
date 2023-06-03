using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PropellerSpin : MonoBehaviour
{
    private float rotateSpeed = 100f;

    void FixedUpdate()
    {
        transform.Rotate(Vector3.forward, rotateSpeed);
    }
}
