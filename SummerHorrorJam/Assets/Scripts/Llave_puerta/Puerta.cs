using UnityEngine;

public class Puerta : MonoBehaviour
{
    public Transform puerta;
    public Transform panel;

    private bool puertaSubida = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && panel.GetComponent<Panel>().panelActivado && !puertaSubida)
        {
            SubirPuerta();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (puertaSubida)
        {
            BajarPuerta();
        }
    }

    private void SubirPuerta()
    {
        puerta.position += new Vector3(0, 5, 0);
        puertaSubida = true;
    }

    private void BajarPuerta()
    {
        puerta.position -= new Vector3(0, 5, 0);
        puertaSubida = false;
    }
}
