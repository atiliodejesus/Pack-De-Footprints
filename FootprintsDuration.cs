using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootprintsDuration : MonoBehaviour
{
    public float timeDuration = 2f;
    private MeshRenderer mesh;
    Color color;


    private void Start()
    {
        mesh = GetComponent<MeshRenderer>();
    }

    void ApplyFunction()
    {
        timeDuration -= Time.deltaTime;
        color.a = timeDuration;
        mesh.material.color = color;

        if (timeDuration <= 0)
            Destroy(transform.gameObject, 0.01f);
    }

    private void Update()
    {
        ApplyFunction();
    }

}
