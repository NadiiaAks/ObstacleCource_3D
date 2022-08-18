using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rb;
    [SerializeField] float timeToWait = 3f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        renderer = GetComponent<MeshRenderer>();
        renderer.enabled = false;
        rb.useGravity = false;
    }
    void Update()
    {
        if(Time.time > timeToWait)
        {
            renderer.enabled = true;
            rb.useGravity = true;
        }
    }
}
