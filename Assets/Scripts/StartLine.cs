using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLine : MonoBehaviour
{
    private void OnCollisionExit(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.blue;
            gameObject.tag = "Hit";
        }
    }
}
