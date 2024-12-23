using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class Task1 : MonoBehaviour
{
    public GameObject slot;
    public void ClickButton()
    {
        slot.SetActive(!(slot.activeSelf));
    }
}