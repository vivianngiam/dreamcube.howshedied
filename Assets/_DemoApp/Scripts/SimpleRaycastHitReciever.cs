using System;
using System.Collections;
using System.Collections.Generic;
using App.TTW.Scripts;
using DG.Tweening;
using UnityEngine;

public class SimpleRaycastHitReciever : RaycastHitReceiver
{

    // Assign a prefab to debug impact point 
    public GameObject visualObject;
    public AudioClip collisionSound;

    //hitPoint is in world space right now
    public override void HitByRaycast(Vector3 hitPoint)
    {
        if (debugHitMarker)
        {
            GameObject marker = Instantiate(debugHitMarker, this.transform.parent);
            marker.AddComponent<DestroyAfterSeconds>();
            marker.transform.forward = transform.transform.parent.forward;
            marker.transform.position = hitPoint - marker.transform.forward * 0.01f;
        }

        if (visualObject)
        {
            AudioManager.Instance.PlaySingle(collisionSound);
            visualObject
                .transform.DOLocalRotate(360f * Vector3.right, 1.0f, RotateMode.LocalAxisAdd)
                .OnComplete(() => visualObject.transform.localRotation = Quaternion.identity);
        }
    }
}
