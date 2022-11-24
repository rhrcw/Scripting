using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    int health = 10;
    int level = 1;
    Vector3 newPosition = transform.position;
    int speed = 2;
    // Start is called before the first frame update
    void Start()
    {
        health = health + level;
    }

    // Update is called once per frame
    void Update()
    {
        newPosition.z +=
speed * Time.deltaTime;
    }
}
