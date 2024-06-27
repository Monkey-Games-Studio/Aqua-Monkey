using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Panel : MonoBehaviour
{
    public Transform panel;
    public Transform llave;
    public bool panelActivado = false;

    private void OnTriggerEnter(Collider other)
    {
        //Si esta con el player, esta la llaveobtenida y pulsas la tecla F activa el panel
        if (other.gameObject.tag == "Player" && llave.GetComponent<Llave_puerta>().llaveobtenida)
        {
            ActivarPanel();
        }
    }

    private void ActivarPanel()
    {
        panelActivado = true;
        Destroy(llave.gameObject);
    }
}
