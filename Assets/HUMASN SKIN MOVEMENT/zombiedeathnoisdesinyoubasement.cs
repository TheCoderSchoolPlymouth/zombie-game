using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombiedeathnoisdesinyoubasement : MonoBehaviour

{
    public AudioSource audioSource;
    public AudioClip[] audioClipArray;
    public float timeBetweenShots = 0.25f;
        float timer;
    // Start is called before the first frame update
    void Start()
    {
        audioSource.Play();

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timeBetweenShots) {
            audioSource.PlayOneShot(RandomClip());
            timer = 0;
        }
    }
    AudioClip RandomClip() {
        return audioClipArray[Random.Range(0, audioClipArray.Length - 1)];
    }
}
