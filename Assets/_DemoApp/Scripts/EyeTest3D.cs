using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeTest3D : MonoBehaviour
{

    [SerializeField] private Transform target;
    public float speed;

    void Update()
    {
        // look at the target
        gameObject.transform.LookAt(target);
    }

    private void LateUpdate()
    {
        LookAtTarget();
    }

    void LookAtTarget()
    {
        Vector3 direction = target.position - transform.position;
        Quaternion toRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Lerp(transform.rotation, toRotation, speed * Time.deltaTime);
    }

    //private void LateUpdate()
    //{
    //    transform.Translate(0, Time.deltaTime, 0);
    //}
}
