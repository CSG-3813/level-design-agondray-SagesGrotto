using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AgondrayEscape : MonoBehaviour
{
    AudioSource audioSrcKey;
    AudioClip audioClpKey;
    public Image RedKeyUI;
    public Image GreenKeyUI;
    public Image BlackKeyUI;

    public bool hasRedKey { get; set; }
    public bool hasYellowKey { get; set; }
    public bool hasGreenKey { get; set; }
    public bool hasBlackKey { get; set; }

    private void Start()
    {
        hasRedKey = false;
        hasYellowKey = false;
        hasGreenKey = false;
        hasBlackKey = false;
        RedKeyUI.enabled = false;
        GreenKeyUI.enabled = false;
        BlackKeyUI.enabled = false;
        audioSrcKey = GetComponent<AudioSource>();
        audioClpKey = audioSrcKey.clip;
    }

    public void KeyGrab(string KeyType)
    {
        if(KeyType == "Red")
        {
            hasRedKey = true;
            RedKeyUI.enabled = true;
            Debug.Log("Red Key: "+ hasRedKey);
        }
        if(KeyType == "Yellow")
        {
            hasYellowKey = true;
            Debug.Log("Yellow Key: "+ hasYellowKey);
        }
        if(KeyType == "Green")
        {
            hasGreenKey = true;
            GreenKeyUI.enabled = true;
            Debug.Log("Green Key: " + hasGreenKey);
        }
        if (KeyType == "Black")
        {
            hasBlackKey = true;
            BlackKeyUI.enabled = true;
            Debug.Log("Black Key: "+ hasBlackKey);
        }
        audioSrcKey.PlayOneShot(audioClpKey);
    }
    private void Update()
    {
    }
}
