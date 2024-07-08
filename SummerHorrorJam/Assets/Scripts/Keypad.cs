using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keypad : MonoBehaviour
{
    public string password = "1234";
    private string userinput = "";
    public bool access;
    public void ButtonClicked(string number)
    {
        userinput += number;
        if (userinput.Length>=4)
        {
            if (userinput == password)
            {
                access = true;
            }
            else
            {
                access = false;
            }
        }
    }
}
