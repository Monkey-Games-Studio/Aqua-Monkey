using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Transform door;
    public Transform panel;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && panel.GetComponent<Panel>().panelActivado)
        {
            AbrirPuerta();
        }
    }

    private void AbrirPuerta()
    {
        door.Translate(Vector3.up * 5);
    }
    private void CerrarPuerta()
    {
        door.Translate(Vector3.down * 5);
    }

}
