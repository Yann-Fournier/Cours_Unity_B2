using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FireWhenCollide : MonoBehaviour
{
    public GameObject PrefabFire;
    
    private void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.name);
        GameObject fire = Instantiate(PrefabFire);
        fire.GetComponent<Transform>().position = GetComponent<Transform>().position;
        Destroy(this.gameObject);
        Destroy(fire.gameObject, 7);
        if (collision.gameObject.tag == "Zombies")
        {
            Destroy(collision.gameObject);
        }
    }
} 
