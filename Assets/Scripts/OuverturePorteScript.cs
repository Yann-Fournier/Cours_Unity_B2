using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuverturePorteScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GetComponent<Animator>().SetBool("IsOpen", true);
    }
    
    private void OnTriggerExit(Collider other)
    {
        GetComponent<Animator>().SetBool("IsOpen", false);
    }
}
