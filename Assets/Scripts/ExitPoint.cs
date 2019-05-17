using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class ExitPoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (other.GetComponent<MaterialSystem>().GetColor() == GetComponent<MaterialSystem>().GetColor())
            {
                GameController.Instance.NextLevel();
            }
            
        }
    }
}
