using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D _rigidbody;
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        run();
        
    }
    void run()
    {
        _rigidbody.velocity = Vector2.left * Input.GetAxis("Horizontal");
    }
}
 