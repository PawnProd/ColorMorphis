using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public Transform entryPoint;

    public GameObject exitPoint;

    public Player player;
    
    public Color exitColor;
   

    void Start()
    {
        player.transform.position = entryPoint.position;

        Vector3 position = player.transform.position;
        position.y = 0.75f;
        player.transform.position = position;
        
        exitPoint.GetComponent<MaterialSystem>().SetColor(exitColor);
    }
    
}
