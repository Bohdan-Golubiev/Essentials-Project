using UnityEngine;
using UnityEngine.Audio;

public class Collectibles : MonoBehaviour
{
    public float rotateSpeed = 1.0f;
    public GameObject onCollectEffect;
    private AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        transform.Rotate(0, rotateSpeed, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            audioSource.Play();
            Destroy(gameObject, audioSource.clip.length);
            Instantiate(onCollectEffect, transform.position, transform.rotation);
        }
    }
}
