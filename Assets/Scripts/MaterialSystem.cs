using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialSystem : MonoBehaviour
{
    private Material _material;

    void Awake()
    {
        _material = GetComponent<MeshRenderer>().material;
    }

    public void SetColor(Color newColor, ColorMode mode = ColorMode.NORMAL)
    {
        switch (mode)
        {
            case ColorMode.NORMAL:
                _material.SetColor("_Color", newColor);
                break;
            case ColorMode.ADDITIVE:
                Color currentColor = GetColor();
                currentColor += newColor;
                _material.SetColor("_Color", currentColor);
                break;
        }
       
    }
    
    

    public Color GetColor()
    {
        Color color = _material.GetColor("_Color");
        color.a = 1;
        return color;
    }
}

public enum ColorMode
{
    ADDITIVE,
    NORMAL
}
