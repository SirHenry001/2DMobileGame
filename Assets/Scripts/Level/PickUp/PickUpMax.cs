using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpMax : MonoBehaviour
{

    public CollisionScript collisionScript;
    public AudioManager audioManager;

    public GameObject effectParticles;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")

        {
            collisionScript.Score(200);
            collisionScript.AddTime(100);
            gameObject.SetActive(false);
            Instantiate(effectParticles, transform.position, transform.rotation);
            audioManager.PlayAudio(1);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        collisionScript = GameObject.Find("HeroCharacter").GetComponent<CollisionScript>();
        audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
