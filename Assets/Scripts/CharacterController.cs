using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float speed = 0;

    public void Move(Vector3 direction, float deltaTime)
    {
        Vector3 movement = speed * deltaTime * direction.normalized;

        transform.Translate(movement);
    }
}
