using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Doorpasword : MonoBehaviour
{
    public Transform door;
    public Transform keypad;
    private bool isOn = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (keypad.GetComponent<Keypad>().access && !isOn)
            {
                door.position += new Vector3(0, 5, 0);
                isOn = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && isOn)
        {
            door.position += new Vector3(0, -5, 0);
            isOn = false;
        }
    }
}
