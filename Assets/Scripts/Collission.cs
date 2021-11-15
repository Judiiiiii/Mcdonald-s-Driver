using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collission : MonoBehaviour
{
    [SerializeField] Color32 yPackageColor = new Color32(171, 236, 15, 255);
    [SerializeField] Color32 nPackageColor = new Color32(241, 228, 228, 255);
    [SerializeField] float destroydelay = 0.5f;
    bool HasPackage;
    SpriteRenderer spriteRenderer;

    void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Ouch!");
        
    }

    void OnTriggerEnter2D(Collider2D other) {
        
        if(other.tag == "Package"&& !HasPackage)
        {
            Debug.Log("Package Pick up!");
            HasPackage = true;
            spriteRenderer.color = yPackageColor;
            Destroy(other.gameObject, destroydelay);
        }

        if(other.tag == "Customers" && HasPackage)
        {
            Debug.Log("Package Delivered!");
            HasPackage = false;
            spriteRenderer.color = nPackageColor;
            Destroy(other.gameObject, destroydelay);
        }

    }

}
