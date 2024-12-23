using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Task2 : MonoBehaviour
{
    public int num = 10;
    public Text col;
    public void OnCollisionEnter(Collision collision)
    {
        num--;
        col.text = num.ToString();
    }
}
