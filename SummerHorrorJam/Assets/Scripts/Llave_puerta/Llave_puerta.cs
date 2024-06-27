using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llave_puerta : MonoBehaviour
{
    public Transform llave;
    public Transform puerta;
    public Transform panel;
    public Transform player;

    bool llave_cogida = false;
    bool panel_abierto = false;
    void Start()
    {
        
    }

    void Update()
    {
        if (llave.GetComponent<Collider>().isTrigger == true && player.GetComponent<Collider>().isTrigger == true && Input.GetKey(KeyCode.F))
        {
            Destroy(llave.gameObject);
            llave_cogida = true;
        }

        if (llave_cogida == true && panel.GetComponent<Collider>().isTrigger == true && Input.GetKey(KeyCode.F))
        {
            panel_abierto = true;
        }

        if (panel_abierto == true && puerta.GetComponent<Collider>().isTrigger == true)
        {
            puerta.position = Vector3.MoveTowards(puerta.position, new Vector3(puerta.position.x, puerta.position.y + 5, puerta.position.z), 0.1f);
        }
    }
}
