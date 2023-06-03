using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    [SerializeField] private GameObject plane;
    private Vector3 offset = new (30f + 0f, 0f);


    void LateUpdate()
    {
        
        transform.position = plane.transform.position + offset;
    }
}
