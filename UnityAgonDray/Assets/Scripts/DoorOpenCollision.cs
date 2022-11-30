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
    public string animtionParamater;
    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            anim.SetBool(animtionParamater, true);
        }
    }
}
