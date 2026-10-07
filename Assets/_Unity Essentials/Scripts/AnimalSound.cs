
using System.Collections;
using UnityEngine;

public class AnimalSound : MonoBehaviour
{

    public AudioSource audioSource;

    public float soundCooldown = 3f; // Cooldown time in seconds
    private bool isReadyToPlay = true; // Flag to check if the sound can be played

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Get the AudioSource component attached to the animal
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // Coroutine to handle the cooldown for playing the sound
    private IEnumerator SoundCooldown()
    {
        isReadyToPlay = false; // Set the flag to false to prevent playing the sound again
        yield return new WaitForSeconds(soundCooldown); // Wait for the cooldown duration
        isReadyToPlay = true; // Reset the flag to allow playing the sound again
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the other object has a PlayerController2D component
        if (collision.gameObject.GetComponent<PlayerController2D>() != null)
        {
            // Play the animal sound if it's not already playing
            if (audioSource != null && isReadyToPlay)
            {
                audioSource.Play();
                StartCoroutine(SoundCooldown());
            }
        }
    }
}

