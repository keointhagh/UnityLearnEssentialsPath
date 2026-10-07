using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible2D : MonoBehaviour
{

    public float rotationSpeed = 0.5f;
    public GameObject onCollectEffect;

    public AudioSource audioSource;

    void Start()
    {
        // Get the AudioSource component attached to the collectible
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(0, 0, rotationSpeed);
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        
         // Check if the other object has a PlayerController2D component
        if (other.GetComponent<PlayerController2D>() != null) {
            
            // Destroy the collectible
            Destroy(gameObject);

            // Instantiate the particle effect
            Instantiate(onCollectEffect, transform.position, transform.rotation);

            // Play the collect sound
            if(audioSource != null)
            {
                audioSource.Play();
                //audioSource = null; // Set audioSource to null to prevent it from playing again
            }
        }

        
    }


}


