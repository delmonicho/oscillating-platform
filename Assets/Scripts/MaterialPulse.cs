using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialPulse : MonoBehaviour
{
    [Header("Opacity Parameters")]
    public float maxOpacity;
    public float minOpacity;
    public float opacityStep;

    [Header("Renderer and Material References")]
    public MeshRenderer objectRenderer;
    public Material objectMaterial;

    public Color tempColor;

    // Start is called before the first frame update
    void Start()
    {
        // get a reference to mesh rendere attached tro this obkect
        objectRenderer = gameObject.GetComponent<MeshRenderer>();
        objectMaterial = objectRenderer.material;

        tempColor = new Color(objectMaterial.color.r, objectMaterial.color.g, objectMaterial.color.b, objectMaterial.color.a);


    }

    // Update is called once per frame
    void Update()
    {
        // iuf opacity reaches the bounds then reverse opacity step
        if (tempColor.a <= minOpacity || tempColor.a >= maxOpacity)
            opacityStep *= -1.0f;
        {
            
        }
        // add opacity to our tempColor
        tempColor.a += opacityStep;
        objectMaterial.SetColor("_Color", tempColor);
    }
}
