using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntoRecogidaController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
