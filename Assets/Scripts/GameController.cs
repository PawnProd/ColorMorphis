using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController Instance { private set; get; }

    public int level = 0;

    private void Awake()
    {
        if (Instance == this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void NextLevel()
    {
        SceneManager.LoadScene("Level_" + level);
        level++;
    }

    

}
