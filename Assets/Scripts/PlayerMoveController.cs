using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMoveController : MonoBehaviour
{
    private readonly float speed = 40.0f;
    private readonly float turnSpeed = 24.0f;
    private float horizontalInput;
    private float forwardInput;
    private int pointsCount = 0;
    public Text pointsText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(forwardInput * speed * Time.deltaTime * Vector3.forward);
        transform.Rotate(horizontalInput * turnSpeed * Time.deltaTime * Vector3.up);
    }

    private void OnCollisionEnter(Collision collision)
    {
        pointsText.text = $"Puntuación: { pointsCount += 1 }";
        Debug.Log("puntos" + pointsCount);
    }
}
