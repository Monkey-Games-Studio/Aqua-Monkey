using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform Objetivo;
    public float Vel;
    public NavMeshAgent IA;
    public float Distance;

    void Update()
    {
        IA.speed = Vel;
        if (Vector3.Distance(transform.position, Objetivo.position) < Distance)
        {
            IA.SetDestination(Objetivo.position);
        }
        else
        {
            IA.SetDestination(transform.position);
        }

    }
}
