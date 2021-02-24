using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarWorldSpaceController : MonoBehaviour
{
    public Transform playerCamera;

    void Start()
    {
        playerCamera = GameObject.Find("PlayerCamera").transform;
    }

    // later update per frames per second
    void LateUpdate()
    {
        // billboard the healthBar
        // point to players camera 
        transform.LookAt(transform.position + playerCamera.forward);
    }
}
