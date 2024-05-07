using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Baril : MonoBehaviour
{
    private bool _isPlayerInTrigger = false;
    private bool _isDestroy = false;
    private void OnTriggerEnter(Collider other)
    {
        _isPlayerInTrigger = true;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && _isPlayerInTrigger && _isDestroy)
        {
            // Recreate(this.gameObject);
            _isDestroy = false;
            print(_isDestroy);
        } else if (Input.GetKeyDown(KeyCode.E) && _isPlayerInTrigger && !_isDestroy)
        {
            Destroy(this.gameObject);
            _isDestroy = true;
            print(_isDestroy);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        _isPlayerInTrigger = false;
    }
}
