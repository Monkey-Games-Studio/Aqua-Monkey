using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Windows;
using static UnityEngine.Rendering.DebugUI;

public class Llave_puerta : MonoBehaviour
{
    public Transform llave;

    public bool llaveobtenida = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Obtener();
        }
    }

    private void Obtener()
    {
        llaveobtenida = true;
        llave.SetParent(GameObject.Find("Player").transform);

    }
}
