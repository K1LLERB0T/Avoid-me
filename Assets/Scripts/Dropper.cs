using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody body;
    [SerializeField] float TimeToWait = 5f;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        body = GetComponent<Rigidbody>();

        renderer.enabled = false;

        body.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > TimeToWait)
        {
            // Debug.Log("Elapsed time: " + Time.time);
            renderer.enabled = true;
            body.useGravity = true;
        }
    }
}
