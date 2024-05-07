using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerBehaviourScript : MonoBehaviour
{

    public float Speed;
    public float JumpForce;
    public float RotationSpeed;
    public Animator CharacterAnimator;
    
    private bool _isGrounded = true;

    // Update is called once per frame
    void Update()
    {
        float speed = Speed * Time.deltaTime;
        
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(speed, 0, 0));
            // GetComponent<Transform>().Rotate(new Vector3(0, RotationSpeed * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(-speed, 0, 0));
            // GetComponent<Transform>().Rotate(new Vector3(0, -RotationSpeed * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Rigidbody>().AddForce(GetComponent<Transform>().forward * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody>().AddForce(-GetComponent<Transform>().forward * speed);
        }
        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(0, JumpForce, 0));
            _isGrounded = false;
        }
        CharacterAnimator.SetBool("IsJumping", !_isGrounded);
        CharacterAnimator.SetFloat("Speed", GetComponent<Rigidbody>().velocity.magnitude);
        // if (_isGrounded)
        // {
        //     CharacterAnimator.SetFloat("Speed", GetComponent<Rigidbody>().velocity.magnitude);
        // }
    }

    private void OnCollisionEnter(Collision collision)
    {
        _isGrounded = true;
        CharacterAnimator.SetBool("IsJumping", false);
    }
}
