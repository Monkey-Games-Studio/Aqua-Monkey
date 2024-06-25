using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform[] objetivos; // Array de todos los objetivos que deseas que el agente persiga
    public Transform player;
    public float velocidad;
    public float distanciaObjetivo;
    public NavMeshAgent agente;

    private Transform objetivoActual;
    private bool objetivoAlcanzado = true;

    void Start()
    {
        // Inicialmente, elige un objetivo aleatorio
        CambiarObjetivo();
    }

    void Update()
    {
        agente.speed = velocidad;

        // Detectar al jugador
        if (Vector3.Distance(transform.position, player.position) < distanciaObjetivo)
        {
            agente.SetDestination(player.position);
        }

        // Cambiar de objetivo si el objetivo actual ha sido alcanzado
        if (objetivoAlcanzado)
        {
            CambiarObjetivo();
            objetivoAlcanzado = false;
        }
        else
        {
            // Verificar si el agente ha alcanzado el objetivo actual
            if (objetivoActual != null && Vector3.Distance(transform.position, objetivoActual.position) < distanciaObjetivo)
            {
                objetivoAlcanzado = true;
            }
        }
    }

    void CambiarObjetivo()
    {
        // Seleccionar un objetivo aleatorio del array de objetivos
        objetivoActual = objetivos[Random.Range(0, objetivos.Length)];
        agente.SetDestination(objetivoActual.position);
    }
}
