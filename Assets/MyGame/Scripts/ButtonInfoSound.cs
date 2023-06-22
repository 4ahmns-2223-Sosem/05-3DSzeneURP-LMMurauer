using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInfoSound : MonoBehaviour
{
   
    public AudioClip infoAudioButtonC;
    private AudioSource infoAudioButtonS;
    public AudioClip clickAudioButtonC;
    private AudioSource clickAudioButtonS;
    public bool isPlaying;

    void Start()
    {
        infoAudioButtonS = gameObject.AddComponent<AudioSource>();
        infoAudioButtonS.clip = infoAudioButtonC;
        infoAudioButtonS.loop = false;
        infoAudioButtonS.playOnAwake = false;
        isPlaying = false;

        clickAudioButtonS = gameObject.AddComponent<AudioSource>();
        clickAudioButtonS.clip = clickAudioButtonC;
        clickAudioButtonS.loop = false;
        clickAudioButtonS.playOnAwake = false;
    }

    private void OnMouseDown()
    {
        clickAudioButtonS.Play();

        if (isPlaying)
        {
            StopAudio();
        }
        else
        {
            ButtonInfoSound[] allButtons = FindObjectsOfType<ButtonInfoSound>();
            foreach (ButtonInfoSound button in allButtons)
            {
                if (button != this && button.isPlaying)
                {
                    button.StopAudio();
                }
            }

            isPlaying = true;
            infoAudioButtonS.Stop();
            infoAudioButtonS.time = 0f;
            infoAudioButtonS.Play();
        }
    }

    public void StopAudio()
    {
        if (isPlaying)
        {
            infoAudioButtonS.Stop();
            isPlaying = false;
            Debug.Log("stopped");
        }
    }

    void Update()
    {
        if (isPlaying)
        {
            if (infoAudioButtonS.time >= infoAudioButtonS.clip.length)
            {
                isPlaying = false;
            }
        }
    }
}

