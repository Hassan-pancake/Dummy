using System.Collections;
using UnityEngine;

public class TrialScript : MonoBehaviour
{
    public bool autoColor=true;

    public float autocolorTimeIntervels=.5f;
    float timerCounter;
    [Tooltip("Make sure you turn off autoColor or this will get overrriden")]
    public Color cubeStaticColor;
    [Range (0,5)]
    public float rotationSpeed;

    Material color;

    private void Start()
    {
        color = GetComponent<Renderer>().material;
        timerCounter = autocolorTimeIntervels;
    }

    private void Update()
    {
        ApplyColor();
       
    }

    void ApplyColor()
    {
        timerCounter -= Time.deltaTime;
        if (autoColor&& timerCounter<0)
        {
            color.color = Random.ColorHSV();
            timerCounter = autocolorTimeIntervels;
        }
        if (!autoColor)
        {
            color.color = cubeStaticColor;
        }
     
    }

    void applyrotaion()
    {

    }

  
}
