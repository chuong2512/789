using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class ColorChange : MonoBehaviour
{
    public Color[] shapeColor;
    public static ColorChange changeColor;
    // Start is called before the first frame update
    void Start()
    {
        changeColor = this;
        GroundColor();
        //Color newColor = new Color(Random.value, Random.value, Random.value, 1.0f);
        // apply it on current object's material
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GroundColor()
    {
        
        int newColor = Random.Range(0, shapeColor.Length);
        GetComponent<Renderer>().material.color = shapeColor[newColor];
    }
}
