using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using dreamcube.unity.Core.Scripts.AssetLoading;
using dreamcube.unity.Core.Scripts.Configuration.GeneralConfig;
using Serilog;

public class TechDemoSceneManager : BaseSceneManager
{
    //should I do a check to see if the scene exists?
    public List<string> DemoSceneNames;
    private int _currentDemoSceneIndex = 0;

    protected override void Start()
    {
        base.Start();
        StartCoroutine(SceneLoader.LoadSceneAsyncNamed(DemoSceneNames[_currentDemoSceneIndex]));
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            Log.Debug("TD Scene Manager 1 Pressed");
            LoadDemoSceneWithIndex(0);
        }
        else if(Input.GetKeyUp(KeyCode.Alpha2))
        {
            Log.Debug("TD Scene Manager 2 Pressed");
            LoadDemoSceneWithIndex(1);
        }
        else if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            Log.Debug("TD Scene Manager 3 Pressed");
            LoadDemoSceneWithIndex(2);
        }
        else if (Input.GetKeyUp(KeyCode.Alpha4))
        {
            Log.Debug("TD Scene Manager 4 Pressed");
            LoadDemoSceneWithIndex(3);
        }
        else if (Input.GetKeyUp(KeyCode.Alpha5))
        {
            Log.Debug("TD Scene Manager 5 Pressed");
            LoadDemoSceneWithIndex(4);
        }
        else if (Input.GetKeyUp(KeyCode.Alpha6))
        {
            Log.Debug("TD Scene Manager 6 Pressed");
            LoadDemoSceneWithIndex(5);
        }

        else if (Input.GetKeyDown(KeyCode.Z))
        {
            ConfigManager.Instance.generalSettings.Debug = !ConfigManager.Instance.generalSettings.Debug;
        }

    }

    private void LoadDemoSceneWithIndex(int newDemoSceneIndex)
    {
        if(newDemoSceneIndex >= DemoSceneNames.Count)
        {
            return;
        }

        if(newDemoSceneIndex != _currentDemoSceneIndex)
        {
            _ = SceneLoader.SwitchScenes(DemoSceneNames[_currentDemoSceneIndex], DemoSceneNames[newDemoSceneIndex]);
            _currentDemoSceneIndex = newDemoSceneIndex;
        }
    }
}
