using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class ButtonClick : MonoBehaviour
{
    public AudioClip clickSound;
    private AudioSource clickSource;


    public void Update()
    {

        
    }

    public void Start()
    {
        Debug.Log("Wird gestartet");
        clickSource = gameObject.AddComponent<AudioSource>();
        clickSource.clip = clickSound;
        clickSource.loop = false;
        clickSource.playOnAwake = false;
    }

    private void OnMouseDown()
    {
        Debug.Log("SpieleSound");
        clickSource.Play();

    }

}
