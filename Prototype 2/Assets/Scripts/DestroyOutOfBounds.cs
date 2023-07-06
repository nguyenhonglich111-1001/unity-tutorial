using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30f;
    private float botBound = -14f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (topBound <= transform.position.z && transform.position.z <= botBound)
        {
            Destroy(gameObject);
        }
    }
}
