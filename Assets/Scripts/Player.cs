using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public LevelController levelController;
    private CharacterController _controller;

    private void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        float v = Input.GetAxisRaw("Vertical");
        float h = Input.GetAxisRaw("Horizontal");
        
        Vector3 direction = new Vector3(h,0,v);
        
        if(direction != Vector3.zero)
            _controller.Move(direction, Time.deltaTime);
        
    }
}
