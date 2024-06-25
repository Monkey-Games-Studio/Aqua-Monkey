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
    bool Objetivoalcanzado = false;
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
        else
        {
            Randomize();
        }

    }
    void Randomize()
    {
        if(Objetivoalcanzado == true)
        {
            random = Random.Range(1, 4);
            Objetivoalcanzado = false;
        }
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
        IA.SetDestination(Objetivo.position);
        if(Vector3.Distance(transform.position, Objetivo.position) < 5)
        {
            Objetivoalcanzado = true;
        }
    }
}







