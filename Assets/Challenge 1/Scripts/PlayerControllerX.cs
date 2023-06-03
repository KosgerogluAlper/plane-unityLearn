using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    readonly private float speed = 20f;
    readonly private float rotationSpeed = 100f;
    private float verticalInput;


    void FixedUpdate()
    {
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * -verticalInput);

    }
}
