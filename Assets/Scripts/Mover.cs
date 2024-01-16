using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    
    void Start()
    {
        PrintInstructions();
    }

    void Update()
    {
        PlayerMovement();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome!\n Move using WASD.\n Avoid hitting the walls!!!");
    }

    void PlayerMovement()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue, 0, zValue);
    }
}
