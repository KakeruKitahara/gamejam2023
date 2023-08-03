using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class HitPole : MonoBehaviour
{
    //[SerializeField] AudioSource audioSource;
    AudioSource audiosource;
    AudioClip audioclip;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        audiosource = this.gameObject.GetComponent<AudioSource>();
        audioclip = audiosource.clip;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            audiosource.PlayOneShot(audioclip);
            //player = collision.gameObject.GetComponent<Transform>();
            //player.enabled = false;
            StartCoroutine(Checking(() =>
            {
                SceneManager.LoadScene("GameoverScene");
            }));
            
        }
    }
    public delegate void functionType();
    private IEnumerator Checking(functionType callback)
    {
        while (true)
        {
            yield return new WaitForFixedUpdate();
            if (!GetComponent<AudioSource>().isPlaying)
            {
                callback();
                break;
            }
        }
    }
}
