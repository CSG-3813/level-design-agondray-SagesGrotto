/***
 * Author: Sage
 * Create: 11/30/22
 * Modified:
 * Description: Opens door
 ***/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenCollision : MonoBehaviour
{
    public AgondrayEscape manager;
    public string animtionParamater;
    Animator anim;
    public string KeyType;
//    AudioSource audioSrc;
//    AudioClip audioClp;

    private void Start()
    {
        anim = GetComponent<Animator>();
 //       audioSrc = GetComponent<AudioSource>();
 //       audioClp = audioSrc.clip;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Being Touched");

        if (KeyType == "Red")
        {
            Debug.Log("Has Red Key = " + manager.hasRedKey);
            if (other.tag == "Player" && manager.hasRedKey)
            {
                Debug.Log("Door Open");
                anim.SetBool(animtionParamater, true);
 //               audioSrc.PlayOneShot(audioClp);
            }
        }

        if (KeyType == "Black")
        {
            Debug.Log("Has Black Key = " + manager.hasBlackKey);
            if (other.tag == "Player" && manager.hasBlackKey)
            {
                Debug.Log("Door Open");
                anim.SetBool(animtionParamater, true);
 //               audioSrc.PlayOneShot(audioClp);
            }
        }

        if (KeyType == "Green")
        {
            Debug.Log("Has Green Key = " + manager.hasGreenKey);
            if (other.tag == "Player" && manager.hasGreenKey)
            {
                Debug.Log("Door Open");
                anim.SetBool(animtionParamater, true);
 //               audioSrc.PlayOneShot(audioClp);
            }
        }


    }
}
