using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCubeController : MonoBehaviour
{
    private Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rigidbody.AddForce(new Vector3(1, 0, 0), ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            rigidbody.AddForce(new Vector3(-1, 0, 0), ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.Z))
        {
            rigidbody.AddForce(new Vector3(0, 0, 1), ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rigidbody.AddForce(new Vector3(0, 0, -1), ForceMode.Impulse);
        }
    }
}
