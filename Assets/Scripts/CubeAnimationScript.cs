using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAnimationScript : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            GetComponent<Animator>().SetBool("Walk", true);
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            GetComponent<Animator>().SetBool("Walk", false);
        }
    }
}
