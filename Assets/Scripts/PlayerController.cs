using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 5.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //The vehicle will move forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
