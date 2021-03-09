using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class ColorPicker : MonoBehaviour
{

    private Color color;

    public void SetRed() => color = Color.red;
    public void SetBlue() => color = Color.blue;
    public void SetYellow() => color = Color.yellow;
}
