using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Audio;


public class ButtonClick : MonoBehaviour
{
    public AudioClip clickSound;
    private AudioSource clickSource;

    public AudioClip voiceSound;
    private AudioSource voiceSource;

    public void Update()
    {

        
    }

    public void Start()
    {
        clickSource = GetComponent<AudioSource>();
        clickSource.clip = clickSound;

        //voiceSource = gameObject.AddComponent<AudioSource>();
        //voiceSource.clip = voiceSound;
    }

    private void OnMouseDown()
    {
        if (clickSound)
        {
            clickSource.Play();
        }
    }

}
