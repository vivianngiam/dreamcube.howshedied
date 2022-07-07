using System.Collections;
using System.Collections.Generic;
using dreamcube.unity.Core.Scripts.Configuration.GeneralConfig;
using UnityEngine;
using TMPro;

public class ToggleInstructions : MonoBehaviour
{
    private MeshRenderer _text;

    void Start()
    {
        _text = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        if( _text.enabled != ConfigManager.Instance.generalSettings.Debug)
            _text.enabled = ConfigManager.Instance.generalSettings.Debug;
    }
} 
        