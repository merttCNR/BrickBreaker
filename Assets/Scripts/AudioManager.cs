using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    AudioSource audioSource;
    public bool isDead = false ;
    void Start()
    {
        audioSource= GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        BBAudio();
    }

    void BBAudio()
    {
        if (isDead == false)
        {
            audioSource.Play();
        }
    }
}
