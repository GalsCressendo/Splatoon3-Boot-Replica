using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.Rendering;

public class BootScene : MonoBehaviour
{
    Renderer renderer;
    float currentTime = 0;
    float intervalTime = 1.5f;

    [Header("STRENGTH")]
    Vector2 strengthRange = new Vector2(1f, 5f);
    const string STRENGTH= "_Strength";

    [Header("CENTER")]
    Vector2 centerRange = new Vector2(0f, 1f);
    const string CENTER= "_Center";

    [Header("OFFSET")]
    Vector2 offsetRange = new Vector2(1f, 5f);
    const string OFFSET = "_Offset";

    [Header("DENSITY")]
    Vector2 densityRange = new Vector2(1f, 4f);
    const string DENSITY = "_NoiseDensity";


    private void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    private void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime == 0)
        {
           AdjustRandomCrippleVectorType(STRENGTH, strengthRange);
           AdjustRandomCrippleVectorType(CENTER, centerRange);
           AdjustRandomCrippleVectorType(OFFSET, offsetRange);

            AdjustRandomCrippleFloatType(DENSITY, densityRange);
        }

        if(currentTime > intervalTime)
        {
            currentTime = 0;
        }

    }

    void AdjustRandomCrippleVectorType(string properties, Vector2 range)
    {
        if (renderer.sharedMaterial.HasProperty(properties))
        {
            float randX = Random.Range(range.x, range.y);
            float randY = Random.Range(range.x, range.y);
            Vector2 rand = new Vector2(randX, randY);

            renderer.sharedMaterial.SetVector(properties, rand);

        }
    }

    void AdjustRandomCrippleFloatType(string properties, Vector2 range)
    {
        if (renderer.sharedMaterial.HasProperty(properties))
        {
            float rand = Random.Range(range.x, range.y);

            renderer.sharedMaterial.SetFloat(properties, Mathf.Lerp(renderer.sharedMaterial.GetFloat(properties), rand, 1));

        }
    }
}
