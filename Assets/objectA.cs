using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectA : MonoBehaviour
{
    public int resolution = 100;
    public float r = 2f;
    public LineRenderer ringRender;

    // Start is called before the first frame update
    void Start()
    {
        DrawRing();
        Destroy(gameObject, 60);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DrawRing()
    {
        ringRender.loop = true;
        ringRender.positionCount = resolution;

        float angle = 0f;
        for(int i = 0; i < resolution; i++)
        {
            float x = r * Mathf.Cos(angle);
            float y = r * Mathf.Sin(angle);

            ringRender.SetPosition(i, new Vector3(x, y, 0f));
            angle += 2f * Mathf.PI/ resolution;
        }

    }
}
