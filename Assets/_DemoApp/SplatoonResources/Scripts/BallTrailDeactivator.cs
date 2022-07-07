using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTrailDeactivator : MonoBehaviour
{
    private bool _cachedValue = true;

    private void OnEnable()
    {
        GameObject ballObject = GameObject.FindGameObjectWithTag("Ball Trail");
        _cachedValue = ballObject.GetComponent<TrailRenderer>().enabled;
        ballObject.GetComponent<TrailRenderer>().enabled = false;
    }

    private void OnDisable()
    {
        GameObject ballObject = GameObject.FindGameObjectWithTag("Ball Trail");
        ballObject.GetComponent<TrailRenderer>().enabled = _cachedValue;
    }
}
