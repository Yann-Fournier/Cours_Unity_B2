using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    // private float Speed = PlayerBehaviourScript.Speed;
    public float Force;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.collider.GetComponent<Rigidbody>()
                .AddForce(GetComponent<Transform>().forward * (Force * Time.deltaTime), ForceMode.Impulse);
            // collision.collider.GetComponent<Rigidbody>().AddForce(transform.up * (Force * Time.deltaTime), ForceMode.Impulse);
        }
    }
}
