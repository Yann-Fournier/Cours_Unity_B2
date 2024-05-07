using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<PlayerBehaviourScript>().JumpForce = 0;
    }

    private void OnTriggerExit(Collider other)
    {
        other.gameObject.GetComponent<PlayerBehaviourScript>().JumpForce = 500;
    }
}
