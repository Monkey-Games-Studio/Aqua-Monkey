using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class ButtonScript : MonoBehaviour
{
    public int keypadnumber;

    public UnityEvent OnButtonPress;

    private void OnMouseDown()
    {
        OnButtonPress.Invoke();
    }
}
