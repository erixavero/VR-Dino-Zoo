using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedingAudioTrigger : MonoBehaviour
{
    public AudioClip eat;
    public AudioClip bad;
    private AudioSource source;
    public string food;
    public string notfood;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // called on trigger
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(food) && !source.isPlaying)
        {
            source.PlayOneShot(eat);
        }
        if (other.CompareTag(notfood) && !source.isPlaying)
        {
            source.PlayOneShot(bad);
        }
    }
}
