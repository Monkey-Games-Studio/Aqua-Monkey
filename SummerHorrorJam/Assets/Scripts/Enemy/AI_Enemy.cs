using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NewBehaviourScript : MonoBehaviour
{
    //Rodrigo el uso de public es para poder modificar las variables desde el editor de Unity
    public Transform[] objetivos; // Array de todos los objetivos a los que puede ir el enemigo
    public Transform player;
    public float velocidad;
    public float distanciaObjetivo;
    public NavMeshAgent malomalote;

    private Transform objetivoActual;
    private Transform objetivoAnterior;
    private bool objetivoAlcanzado = true;

    void Start()
    {
        //Empieza definiendo el primer objetivo al que ir
        CambiarObjetivo();
    }

    void Update()
    {
        malomalote.speed = velocidad;

        // Funcion para detectar si el puto muñeco del Didac este cerca para ir a mover el perro detrás de él
        if (Vector3.Distance(transform.position, player.position) < distanciaObjetivo)
        {
            malomalote.SetDestination(player.position);
        }

        // Cambia de objetivo si el objetivo actual ha sido alcanzado
        if (objetivoAlcanzado)
        {
            CambiarObjetivo();//Llama a la funcion que cambia de objetivo
            objetivoAlcanzado = false;//Lo pone en false para que no se quede en bucle
        }
        else
        {
            // Verificar si el enemigo ha alcanzado su objetivo
            if (objetivoActual != null && Vector3.Distance(transform.position, objetivoActual.position) < distanciaObjetivo)
            {
                objetivoAlcanzado = true;
            }
        }
    }

    void CambiarObjetivo()
    {
        // Seleccionar un objetivo aleatorio que no sea el mismo que el anteriormente alcanzado
        do
        {
            objetivoActual = objetivos[Random.Range(0, objetivos.Length)];
        } while (objetivoActual == objetivoAnterior); // Do while el eterno olvidado

        // Actualizar el objetivo anterior
        objetivoAnterior = objetivoActual;

        malomalote.SetDestination(objetivoActual.position);
    }
}
