﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//This script manages the spawning of obstacles
public class ObstacleSpawner : MonoBehaviour
{
    public float sendTimer = 1;
    public float frequency = 2;
    public float position;
    public GameObject Obstacle;
    public GameObject AngryDuck;

    [SerializeField] private Text txt_score = null;
    [SerializeField] private Text txt_message = null;

    void Update()
    {
        sendTimer -= Time.deltaTime;
        if (sendTimer <= 0)
        {
            position = Random.Range(.68f, 2f);
            transform.position = new Vector3(0, position, -3.7f);
            Instantiate(Obstacle, transform.position, transform.rotation);
            sendTimer = frequency;
        }

        if (AngryDuck != null) Time.timeScale = 1;
        else Time.timeScale = 0;

    }
}
