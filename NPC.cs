using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public int health = 5;
    public int level = 1;
    public float speed = 1.2f;
    public Vector3 newPosition;
    void Start()
    {
    health += level;
    print(health);
    }

    
    void Update()
    {
    newPosition = transform.position;
    newPosition.z += speed * Time.deltaTime;
    transform.position = newPosition;
    }
}
