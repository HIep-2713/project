using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blinking : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public float blinkInterval = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        InvokeRepeating("Blink", 0f, blinkInterval);
    }

    // Update is called once per frame
    void Blink()
    {
        spriteRenderer.enabled = !spriteRenderer.enabled;
        
    }
}
