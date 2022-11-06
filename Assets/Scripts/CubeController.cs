using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position;
    }

    private void Update()
    {
        transform.position += transform.forward * Time.deltaTime * Spawner.speedObject; 
        var dastance = (transform.position - startPosition).magnitude;
        if (dastance > Spawner.distance)
        {
            Destroy(gameObject);
        }
    }
}
