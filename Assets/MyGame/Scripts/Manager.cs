using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    
    public string targetSceneName; 

    private void OnTriggerEnter(Collider other)
    {
        // Überprüfe, ob der Kollidierende das Player-Objekt ist
        if (other.CompareTag("Player"))
        {
            // Lade die Zielszene
            SceneManager.LoadScene(targetSceneName);
        }
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        
        
    }
}
