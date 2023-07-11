using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public float radius = 2f;
    public float speed = 1f;
    private float angle = 0f;
    private Vector3 centerPosition;
    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        centerPosition = transform.position;
        transform.localScale = Vector3.one * 1.3f;

    }

    void Update()
    {
        Rotate();
        MoveCircle();
        InvokeRepeating("ChangeColor", 0.1f, 0.75f);
    }

    void Rotate()
    {
        transform.Rotate(10.0f * Time.deltaTime, 0.2f, 0.2f);

    }

    void MoveCircle()
    {
        angle += speed * Time.deltaTime;
        float x = Mathf.Cos(angle) * radius;
        float z = Mathf.Sin(angle) * radius;
        Vector3 newPosition = centerPosition + new Vector3(x, 0f, z);
        transform.position = newPosition;
    }
    void ChangeColor()
    {
        Material material = Renderer.material;
        material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }
}
