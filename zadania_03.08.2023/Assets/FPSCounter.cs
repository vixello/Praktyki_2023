using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.IO;
using UnityEngine;

public class FPSCounter : MonoBehaviour
{
    public float updateInterval = 60f; 
    public string outputFilePath = "FPSLog.txt"; 

    private float accum = 0.0f;
    private int frames = 0;
    private float timeLeft;

    void Start()
    {
        timeLeft = updateInterval;
    }

    void Update()
    {
        timeLeft -= Time.deltaTime;
        accum += Time.timeScale / Time.deltaTime;
        frames++;

        if (timeLeft <= 0.0f)
        {
            float fps = accum / frames;

            SaveFPSToFile(fps);

            timeLeft = updateInterval;
            accum = 0.0f;
            frames = 0;
        }
    }

    void SaveFPSToFile(float fps)
    {
        string fpsString = fps.ToString("F2");
        File.AppendAllText(outputFilePath, fpsString + "\n");
    }
}
