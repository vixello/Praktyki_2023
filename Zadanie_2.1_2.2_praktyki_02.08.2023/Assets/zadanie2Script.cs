using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zadanie2Script : MonoBehaviour
{

    float[] values = new float[100];

    public Text floatText;
    public Text allGeneratedFloats;
    int seed = 1;

    // Start is called before the first frame update
    void Start()
    {
        RandomFloats();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RandomFloats()
    {
        Random.InitState(seed);
        allGeneratedFloats.text = "";

        for (int i = 0; i< values.Length; i++)
        {
            values[i] = Random.Range(0.1f,100f);
        }

        float current = values[0];
        for (int i = 1; i < 100; i++)
        {

            switch (i % 4)
            {
                case 0: current += values[i];
                    break;
                case 1: current -= values[i];
                    break;
                case 2: current *= values[i];
                    break;
                case 3: current /= values[i];
                    break;
            }
            Debug.Log($"Current {i} {current}");

            allGeneratedFloats.text += $"{i}: {current}\t";
        }
        floatText.text = current.ToString();

    }
}
