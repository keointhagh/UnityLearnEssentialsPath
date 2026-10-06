using UnityEngine;

public class Furniture : MonoBehaviour
{

    [Tooltip("Sound when colliding with the furniture.")]
    public GameObject onCollision;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the player collided with the furniture
        if (collision.gameObject.CompareTag("Player"))
        {
            // Instantiate the onCollision sound
            Instantiate(onCollision, transform.position, transform.rotation);
        }
    }
}
