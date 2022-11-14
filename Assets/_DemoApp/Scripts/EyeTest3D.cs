using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeTest3D : MonoBehaviour
{

    [SerializeField] private Transform target;

    void Update()
    {
        // look at the target
        gameObject.transform.LookAt(target);
    }
}
