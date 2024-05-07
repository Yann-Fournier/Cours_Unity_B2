using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    public GameObject PrefabAxes;
    public float ProjectilSpeed;
    public Transform SpawnPositionPrefab;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject projectile = Instantiate(PrefabAxes);
            // projectile.GetComponent<Transform>().position = GetComponent<Transform>().position + GetComponent<Transform>().forward;
            projectile.GetComponent<Transform>().position = SpawnPositionPrefab.position;
            projectile.GetComponent<Rigidbody>().AddForce(GetComponent<Transform>().forward * ProjectilSpeed);
            Destroy(projectile.gameObject, 7);
        }
    }
}
