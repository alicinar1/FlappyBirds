using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BirdMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float flapForce = 300f;
    [SerializeField] private GameOver gg;
    [SerializeField] private ObstacleSpawner obsSpaw;
    [SerializeField] private Animator animator;
    [SerializeField] private GameObject scoreTrigger;
    [SerializeField] private AudioClip flap;
    [SerializeField] private AudioClip smash;

    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        rb = transform.GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(new Vector3(0, -1 * Time.deltaTime * gravityForce, 0));

        if (Touchscreen.current.press.wasPressedThisFrame)
        {
            Flap();
        }
    }

    private void Flap()
    {
        rb.AddForce(Vector2.up * flapForce);

        audioSource.PlayOneShot(flap);

        Debug.Log("Falan");        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
            audioSource.PlayOneShot(smash);

            gg.GameEnd();

            DisableComponents();    
                
    }

    private void DisableComponents()
    {
        this.GetComponent<BirdMovement>().enabled = false;

        GetComponent<CircleCollider2D>().enabled = false;

        obsSpaw.GetComponent<ObstacleMovement>().enabled = false;

        obsSpaw.GetComponent<ObstacleSpawner>().enabled = false;

        animator.enabled = false;

        scoreTrigger.GetComponent<ObstacleMovement>().enabled = false;
    }
}
