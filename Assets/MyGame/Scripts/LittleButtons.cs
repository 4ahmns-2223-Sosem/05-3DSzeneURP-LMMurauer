using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LittleButtons : MonoBehaviour
{
    public GameObject infografik;
    public GameObject infoText;
    public bool isPressed;
    public float clipLenght;

    public AudioClip infoAudioClip;
    private AudioSource infoAudioS;
    public AudioClip clickAudioClip;
    private AudioSource clickAudioSource;
    private float currentTime;

    public bool isPlaying;

    void Start()
    {
        infoAudioS = gameObject.AddComponent<AudioSource>();
        infoAudioS.clip = infoAudioClip;
        infoAudioS.loop = false;
        infoAudioS.playOnAwake = false;
        isPressed = false;
        clipLenght = infoAudioS.clip.length;
        currentTime = clipLenght;

        clickAudioSource = gameObject.AddComponent<AudioSource>();
        clickAudioSource.clip = clickAudioClip;
        clickAudioSource.loop = false;
        clickAudioSource.playOnAwake = false;
    }

    private void OnMouseDown()
    {
        clickAudioSource.Play();

        if (isPressed)
        {
            StopAudio();
        }
        else
        {
            LittleButtons[] allButtons = FindObjectsOfType<LittleButtons>();
            foreach (LittleButtons button in allButtons)
            {
                if (button != this && button.isPlaying)
                {
                    button.StopAudio();
                }
            }

            isPressed = true;
            infoAudioS.Stop(); 
            infoAudioS.time = 0f;
            infoAudioS.Play();
            isPlaying = true;
            Debug.Log("played");
        }


    }

    public void StopAudio()
    {
        if (isPlaying)
        {
            infoAudioS.Stop();
            isPlaying = false;
            Debug.Log("stopped");
        }
    }

    public void GrafikErscheinen()
    {

        if (isPressed)
        {
            infografik.SetActive(true);
            infoText.SetActive(false);
        }

        else
        {
            infografik.SetActive(false);
            infoText.SetActive(true);
        }
    }

    void Update()
    {
        GrafikErscheinen();

        if (isPressed && isPlaying)
        {
            if (infoAudioS.time >= clipLenght)
            {
                isPressed = false;
                isPlaying = false;
            }
        }

        if (isPlaying == false)
        {
            isPressed = false;
        }
    }   
}
