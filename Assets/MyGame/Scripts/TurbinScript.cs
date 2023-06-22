using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading;

public class TurbinScript : MonoBehaviour
{
    public AudioClip turbinenoClip;
    private AudioSource turbinenSource;
    private float timer = 0f;
    private float duration = 20f;

    void Start()
    {
        turbinenSource = gameObject.AddComponent<AudioSource>();
        turbinenSource.clip = turbinenoClip;
        turbinenSource.loop = false;
        turbinenSource.playOnAwake = false;

        turbinenSource.maxDistance = 20;

        StartCoroutine(StopSoundAfterDelay());

    }

    private System.Collections.IEnumerator StopSoundAfterDelay()
    {
        float timer = 0f;
        turbinenSource.Play();
        

        while (timer < duration)
        {

            timer += Time.deltaTime;
            yield return null;
            
        }

        turbinenSource.Stop();

        Debug.Log("start");
    }

    void Update()
    {
        
    }
}
