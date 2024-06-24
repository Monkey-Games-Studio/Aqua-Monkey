using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform Objetivo;
    public float Vel;

    public NavMeshAgent IA;

    void Update()
    {
        IA.speed = Vel;
        IA.SetDestination(Objetivo.position);
    }
}
