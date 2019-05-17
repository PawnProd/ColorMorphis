using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (other.GetComponent<MaterialSystem>().GetColor() == Color.white)
            {
                other.GetComponent<MaterialSystem>().SetColor(GetComponent<MaterialSystem>().GetColor(), ColorMode.NORMAL);
            }
            else
            {
                other.GetComponent<MaterialSystem>().SetColor(GetComponent<MaterialSystem>().GetColor(), ColorMode.ADDITIVE);
            }
           
        }
    }
}
