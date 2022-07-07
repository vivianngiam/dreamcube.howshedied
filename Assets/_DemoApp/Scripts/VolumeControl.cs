using System.Collections;
using System.Collections.Generic;
using dreamcube.unity.Core.Scripts.Configuration.GeneralConfig;
using UnityEngine;

public class VolumeControl : MonoBehaviour
{
    [Range(0,1)]
    [SerializeField] private float _volume;

    void Start()
    {
        _volume = ConfigManager.Instance.generalSettings.Volume;
    }

    void Update()
    {

        AudioListener.volume = _volume;
    }

    void OnGUI()
    {
        if (ConfigManager.Instance.generalSettings.Debug)
        {
            int yOffset = 180;
            int xOffset = 180;

            _volume = GUI.HorizontalSlider(new Rect(xOffset, yOffset+35, 200, 30), _volume, 0.0F, 1.0F);
            GUI.Label(new Rect(xOffset, yOffset + 10, 350, 20), $"Volume: {_volume}");

        }
    }
}
