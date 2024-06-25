using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform Objetivo_1;
    public Transform Objetivo_2;
    public Transform Objetivo_3;
    Transform Objetivo = null;

    bool Objetivoalacanzado = true;

    public Transform Player;
    public float Vel;
    public NavMeshAgent IA;
    public float Distance;
    int random;

    void Update()
    {
        IA.speed = Vel;

        if (Vector3.Distance(transform.position, Player.position) < Distance)
        {
            IA.SetDestination(Player.position);
        }

        if (Objetivoalacanzado)
        {
            Randomize();
            Objetivoalacanzado = false;
        }

        if (Objetivo != null && Vector3.Distance(transform.position, Objetivo.position) <= 1)
        {
            Objetivoalacanzado = true;
        }
    }

    void Randomize()
    {
        random = Random.Range(1, 4);

        switch (random)
        {
            case 1:
                Objetivo = Objetivo_1;
                break;
            case 2:
                Objetivo = Objetivo_2;
                break;
            case 3:
                Objetivo = Objetivo_3;
                break;
        }

        if (Objetivo != null)
        {
            IA.destination = Objetivo.position;
        }
    }
}
