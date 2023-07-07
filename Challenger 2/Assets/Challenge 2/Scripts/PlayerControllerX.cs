using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;    
    public float fireRate = 0.5f;
    public float lastFire = 0.0f;
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog. And have fire rate.
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > fireRate + lastFire)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            lastFire = Time.time;
        }

    }
}
