using UnityEngine;

public class PlayerSound : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private Rigidbody2D body;

    private void PlaySound()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Start() { }

    // Update is called once per frame
    public void Update()
    {
        Vector2 velocity = body.linearVelocity;
        if (velocity.x != 0)
        {
            PlaySound();
        }
    }
}