using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{
    private Light lightComponent;
    // Start is called before the first frame update
    private void Start()
    {
        // Get the Light component attached to the same GameObject
        lightComponent = GetComponent<Light>();

        // Check if the Light component was found
        if (lightComponent != null)
        {
            // Change the color of the Light component
            // lightComponent.name = 'hey';
        }
        else
        {
            Debug.LogWarning("No Light component found on this GameObject.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
