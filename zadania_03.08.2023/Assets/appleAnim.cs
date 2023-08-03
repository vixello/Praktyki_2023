using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appleAnim : MonoBehaviour
{
    private struct ScaleAnimationData
    {
        public Vector3 startScale;
        public Vector3 targetScale;
        public float duration;
    }
    private ScaleAnimationData[] animationData;
    float t = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
/*        Application.targetFrameRate = 60;
*/
        animationData = new ScaleAnimationData[]
        {
            new ScaleAnimationData { startScale = new Vector3(0.0f, 0.0f, 0.0f),targetScale = new Vector3(0.17f, 0.17f, 1f), duration = 0.17f },
            new ScaleAnimationData { startScale = new Vector3(0.17f, 0.17f, 1f), targetScale = new Vector3(0.49f, 0.49f, 1f), duration = 0.12f },
            new ScaleAnimationData { startScale = new Vector3(0.49f, 0.49f, 1f), targetScale = new Vector3(1.4f, 1.4f, 1f), duration = 0.13f },
            new ScaleAnimationData { startScale = new Vector3(1.4f, 1.4f, 1f), targetScale = new Vector3(1.3f, 1.3f, 1f), duration = 0.06f },
            new ScaleAnimationData { startScale = new Vector3(1.3f, 1.3f, 1f), targetScale = new Vector3(1f, 1f, 1f), duration = 0.11f },
            new ScaleAnimationData { startScale = new Vector3(1f, 1f, 1f), targetScale = new Vector3(1f, 1f, 1f), duration = 0.16f }
    };
        StartCoroutine(PopUpAnim());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator PopUpAnim()
    {
        int i = 0;
        while (i < 1000){ 
            foreach (ScaleAnimationData x in animationData)
            {

                float elapsedTime = 0f;

                while(elapsedTime < x.duration)
                {
                    float t = elapsedTime / x.duration;
                    transform.localScale = Vector3.Lerp(x.startScale, x.targetScale, t);
                    elapsedTime += Time.deltaTime;
                    yield return null;
                }

                transform.localScale = x.targetScale;

            }
            i++;
            yield return null;

        }
    }
}
