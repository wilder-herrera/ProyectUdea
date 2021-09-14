using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveController : MonoBehaviour
{
    private readonly float _speed = 40.0f;
    private readonly float _turnSpeed = 24.0f;
    private float _horizontalInput;
    private float _forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _forwardInput = Input.GetAxis("Vertical");

        transform.Translate(_forwardInput * _speed * Time.deltaTime * Vector3.forward);
        transform.Rotate(_horizontalInput * _turnSpeed * Time.deltaTime * Vector3.up);
    }
}
