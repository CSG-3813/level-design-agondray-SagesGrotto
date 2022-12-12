using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Confetti : MonoBehaviour
{
    public ParticleSystem PS1;
    public ParticleSystem PS2;
    public ParticleSystem PS3;
    public ParticleSystem PS4;
    public ParticleSystem PS5;
    public ParticleSystem PS6;
    AudioSource audioSrc;
    AudioClip audioClp;

    // Start is called before the first frame update
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        audioClp = audioSrc.clip;
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            PS1.Play();
            PS2.Play();
            PS3.Play();
            PS4.Play();
            PS5.Play();
            PS6.Play();
            audioSrc.PlayOneShot(audioClp);
        }
    }

}
