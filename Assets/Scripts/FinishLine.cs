using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.blue;
            gameObject.tag = "Hit";
        }
    }
}
