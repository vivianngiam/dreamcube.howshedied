using System.Collections.Generic;
using dreamcube.unity.Core.Scripts.General;
using UnityEngine;

public class AudioManager : Singleton<AudioManager>
{
    [SerializeField] public AudioSource efxSource; //Drag a reference to the audio source which will play the sound effects.
    [SerializeField] public float highPitchRange = 1.05f; //The highest a sound effect will be randomly pitched.
    [SerializeField] float lowPitchRange = .95f; //The lowest a sound effect will be randomly pitched.
    [SerializeField] public AudioSource musicSource; //Drag a reference to the audio source which will play the music.

    protected override void Awake()
    {
        base.Awake();
        if (musicSource == null)
        {
            musicSource = gameObject.AddComponent<AudioSource>();
        }

        if (efxSource == null)
        {
            efxSource = gameObject.AddComponent<AudioSource>();
        }
    }

    //Used to play single sound clips.
    public void PlaySingle(AudioClip clip, float volume = 1)
    {
        //Set the clip of our efxSource audio source to the clip passed in as a parameter.
        efxSource.clip = clip;

        // set the volume
        efxSource.volume = volume;

        //Play the clip.
        efxSource.Play();
    }


    //RandomizeSfx chooses randomly between various audio clips and slightly changes their pitch.
    public void RandomizeSfx(List<AudioClip> clips)
    {
        //Generate a random number between 0 and the length of our array of clips passed in.
        var randomIndex = Random.Range(0, clips.Count);

        //Choose a random pitch to play back our clip at between our high and low pitch ranges.
        var randomPitch = Random.Range(lowPitchRange, highPitchRange);

        //Set the pitch of the audio source to the randomly chosen pitch.
        efxSource.pitch = randomPitch;

        //Set the clip to the clip at our randomly chosen index.
        efxSource.clip = clips[randomIndex];

        //Play the clip.
        efxSource.Play();
    }
}