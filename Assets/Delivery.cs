using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    bool hasPackage;
    [SerializeField] Color32 hasPackageColor = new Color32 (253, 8, 191, 255);
    [SerializeField] Color32 noPackageColor = new Color32 (250, 241, 13, 255);
    [SerializeField] float destroyDelay = 0.5f;
    
    SpriteRenderer spriteRenderer;

    void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();    
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Ouch!");
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        // tagged the pink thing with the tag Package
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package picked up!");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destroyDelay);

        }

        if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Customer Delivered");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
