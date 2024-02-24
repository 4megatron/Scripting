using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NPC : MonoBehaviour
{
    // player details
    public int health = 5;
    public int level = 1;
    public float speed = 1.2f;

    // Start is called before the first frame update
    void Start()
    {
        health += level;
        print(health);
    } 

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;



    }
}
