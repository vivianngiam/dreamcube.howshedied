using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Serilog;
using dreamcube.unity.Core.Scripts.Signals.Events;

public class AudioFeedback : MonoBehaviour
{
    //public List<ttw.prototype.appEventType> events;

    //eventStrings[i] should match up with audioClips[i]
    //not the most elegant way of doing this when using strings
    public List<string> eventStrings;
    public List<AudioClip> audioClips;

    private AudioSource _audioSource;

    private void Start()
    {
        _audioSource = gameObject.AddComponent<AudioSource>();
    }

    public void OnEnable()
    {
        if (eventStrings.Count == audioClips.Count)
        {

            //bool test = "Event5SecondsLeft" == ttw.EventStrings.Event5SecondsLeft;
            //Log.Debug($"testing: {test}");

            foreach (var s in eventStrings)
            {
                //Log.Debug($"event string: {s}");
                EventManager.Instance.StartListening(s, EventHandler);
            }
        }

        //EventManager.Instance.StartListening(ttw.EventStrings.EventGoodScore, EventHandler);
    }

    private void OnDestroy()
    {
        //if(EventManager.Instance != null )
            //EventManager.Instance.StopListening(ttw.EventStrings.EventGoodScore, EventHandler);

    }

    public void OnDisable()
    {
        if (eventStrings.Count == audioClips.Count)
        {

            foreach (var s in eventStrings)
            {
                if (EventManager.Instance != null)
                {
                    EventManager.Instance.StopListening(s, EventHandler);
                }
            }
        }
    }

    private void EventHandler(string theEvent, string msg, GameObject sender, DataModelBase data)
    {
        //Log.Debug("event handled");

        if (eventStrings.Count == audioClips.Count)
        {
            //Log.Debug("things equal");
            for (int i = 0; i < eventStrings.Count; i++)
            {
                if (theEvent == eventStrings[i])
                {
                    //Log.Debug("playing one shot");
                    _audioSource.PlayOneShot(audioClips[i]);
                }
            }
        }
    }
}
