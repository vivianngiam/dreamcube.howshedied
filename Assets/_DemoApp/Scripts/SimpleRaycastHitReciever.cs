using System;
using System.Collections;
using System.Collections.Generic;
using App.TTW.Scripts;
using DG.Tweening;
using UnityEngine;

public class SimpleRaycastHitReciever : RaycastHitReceiver
{

    // Assign a prefab to debug impact point 
    public GameObject VisualObject;
    public AudioClip CollisionSound;
    public float Volume = 1;


    // hitPoint is in world space
    public override void HitByRaycast(Vector3 hitPoint)
    {
        if (debugHitMarker)
        {
            GameObject marker = Instantiate(debugHitMarker, this.transform.parent);
            marker.AddComponent<DestroyAfterSeconds>();
            marker.transform.forward = transform.transform.parent.forward;
            marker.transform.position = hitPoint - marker.transform.forward * 0.01f;
        }

        if (VisualObject)
        {
            AudioManager.Instance.PlaySingle(CollisionSound, Volume);
            VisualObject
                .transform.DOLocalRotate(360f * Vector3.right, 1.0f, RotateMode.LocalAxisAdd)
                .OnComplete(() => VisualObject.transform.localRotation = Quaternion.identity);
        }
    }
}
