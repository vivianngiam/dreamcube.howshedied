using System;
using dreamcube.unity.Core.Scripts.Debugging;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class BallTrackerActivator : MonoBehaviour
{
    [SerializeField] private Color CrossHairsColor = Color.red ;
    private List<BallToWallProjectionMarker> markers;
    private bool _isActive;

    void Start()
    {
        markers = FindObjectsOfType<BallToWallProjectionMarker>(true).ToList();
        ActivateMarkers(false);
    }

    private void ActivateMarkers( bool isActive )
    {
        _isActive = isActive;
        foreach (var marker in markers)
        {
            marker.gameObject.SetActive(isActive);
            marker.GetComponent<SpriteRenderer>().color = CrossHairsColor;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            _isActive = !_isActive;
            ActivateMarkers(_isActive);
        }
    }
}
