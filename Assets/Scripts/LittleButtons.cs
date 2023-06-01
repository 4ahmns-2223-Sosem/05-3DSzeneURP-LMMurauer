using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LittleButtons : MonoBehaviour
{
    public GameObject infografik;
    public bool isPressed;
    public float clipLenght;

    public AudioClip infoAudioClip;
    private AudioSource infoAudioS;
    private float currentTime;

    void Start()
    {
        infoAudioS = gameObject.AddComponent<AudioSource>();
        infoAudioS.clip = infoAudioClip;
        infoAudioS.loop = false;
        infoAudioS.playOnAwake = false;
        isPressed = false;
        clipLenght = infoAudioS.clip.length;
        currentTime = clipLenght;
    }

    private void OnMouseDown()
    {
        if (isPressed == false)
        {
            isPressed = true;
            infoAudioS.Play();
        }
        
    }
    
    public void GrafikErscheinen()
    { 
        
       infografik.SetActive(true);
            
    }

    void Update()
    {
        if (isPressed == true)
        {
            if (currentTime > 0)
            {
                currentTime -= Time.deltaTime;
                Debug.Log("Time remaining: " + currentTime.ToString("0.00"));

            }
            else
            {
                isPressed = false;
            }
        }
        
    }
}
