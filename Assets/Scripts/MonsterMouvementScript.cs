using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonsterMouvementScript : MonoBehaviour
{
    private Vector3 _startPosition;
    private void Start()
    {
        _startPosition = GetComponent<Transform>().position;
    }
    
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            GetComponent<NavMeshAgent>().SetDestination(GameManager.Instance.Player.GetComponent<Transform>().position);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            GetComponent<NavMeshAgent>().SetDestination(_startPosition);
        }
    }
}
