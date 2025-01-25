using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    private Spawner spawner;
     private void Awake()
    {
        spawner = GameObject.Find("Spawner").GetComponent<Spawner>();
    }

    void Start()
    {
        spawner.active = false;
    }
    private void Update()
    {
        if (Input.anyKeyDown)
        {
            spawner.active = true;
        }
    }
}
