using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LittleButtons : MonoBehaviour
{
    public GameObject infografik;

    public AudioClip infoAudioClip;
    private AudioSource infoAudioS;

    void Start()
    {
        infoAudioS = gameObject.AddComponent<AudioSource>();
        infoAudioS.clip = infoAudioClip;
        infoAudioS.loop = false;
        infoAudioS.playOnAwake = false;
    }

    private void OnMouseDown()
    {
        infoAudioS.Play();
        while (infoAudioS)
        {
            infografik.SetActive(true);
        }
    }
    
    void Update()
    {
        
    }
}
