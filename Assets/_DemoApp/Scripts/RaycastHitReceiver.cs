using System;
using System.Collections;
using System.Collections.Generic;
using App.TTW.Scripts;
using DG.Tweening;
using UnityEngine;

public class RaycastHitReceiver : MonoBehaviour
{
    // Assign a prefab to debug impact point 
    public GameObject debugHitMarker;
    private Collider _collider;

    protected virtual void Start()
    {
        _collider = GetComponent<Collider>();
    }

    //hitPoint is in world space right now
    public virtual void HitByRaycast(Vector3 hitPoint)
    {
        //Debug.Log($"I was hit {gameObject.name}");
        if (debugHitMarker != null)
        {
            GameObject marker = Instantiate(debugHitMarker, this.transform);
            marker.AddComponent<DestroyAfterSeconds>();
            marker.transform.forward = transform.transform.parent.forward;
            marker.transform.position = hitPoint - marker.transform.forward * 0.01f;
        }
    }
}