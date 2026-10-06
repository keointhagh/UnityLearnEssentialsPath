using UnityEngine;

public class Collectible : MonoBehaviour
{
    [Tooltip("Rotation speed of Gem.")]
    public float rotationSpeed = 0.5f;

    [Tooltip("Effects when collecting gems.")]
    public GameObject onCollectEffect;

    [Tooltip("Sound when collecting gems.")]
    public GameObject onCollectSound;

    //Test
    //Vector3 testPosition = new Vector3(-3, 0, -2.5f);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Rotate the collectible around the Y-axis
        transform.Rotate(0, rotationSpeed, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the player collided with the collectible
        if (other.CompareTag("Player"))
        {
            // Destroy the collectible
            Destroy(gameObject);
        }
        //Instantiate the onCollectEffect
        Instantiate(onCollectEffect, transform.position, transform.rotation);
        
        //Instantiate the onCollectSound
        Instantiate(onCollectSound, transform.position, transform.rotation);

        //Test
        //Instantiate(onCollectEffect, testPosition, transform.rotation);
    }
}
