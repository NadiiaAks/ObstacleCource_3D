using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spiner : MonoBehaviour
{
    [SerializeField] float yAngle = 1;
    void Update()
    {
        transform.Rotate(0, yAngle, 0);
    }
}
