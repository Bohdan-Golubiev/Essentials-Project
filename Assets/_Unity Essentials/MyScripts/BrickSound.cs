using UnityEngine;

public class BrickSound : MonoBehaviour
{
    private AudioSource audioSource;
    private float startTime;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        startTime = Time.time;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (Time.time - startTime < 0.05f) return;
        if (collision.gameObject.CompareTag("Brick") || collision.gameObject.CompareTag("Target"))
        {
            if (audioSource != null && !audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
    }
}
