using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class objectB : MonoBehaviour
{
    public GameObject objectA;
    public float a = 1f;
    public float b = 2f;
    public float delta = Mathf.PI / 2f;
    public float time = 0f;
    float movementSpeed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        time = 500000f;

    }


    // Update is called once per frame
    void Update()
    {
        if (objectA != null)
        {
            LissajousMovement();
        }
        else
        {
            Debug.Log("ObjectA is null");
        }

    }
    void LissajousMovement()
    {


        float radiusOfObjectA = objectA.GetComponent<objectA>().r;
        Debug.Log("Radius of Object A: " + radiusOfObjectA);
        
   
        time += Time.deltaTime * movementSpeed;
        Debug.Log($"{time}");
        // x = Asin(at + delta)
        // y = Bsin(bt)
        //A and B are 1f; 

        float x = (radiusOfObjectA - 0.25F) * Mathf.Sin(a * time + delta);
        float y = Mathf.Sin(b * time);
        

        Vector3 positionOfA = objectA.transform.position;
        Vector3 offset = new Vector3(x, y, 0f);

        transform.position = offset;

    }
}
