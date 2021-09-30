using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float flapForce = 300f;
    [SerializeField] private GameOver gg;
    [SerializeField] private ObstacleSpawner obsSpaw;
    [SerializeField] private Animator animator;
    [SerializeField] private GameObject scoreTrigger;

    // Start is called before the first frame update
    void Start()
    {
        rb = transform.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(new Vector3(0, -1 * Time.deltaTime * gravityForce, 0));

        if (Input.GetMouseButtonDown(0))
        {
            Flap();
        }
    }

    private void Flap()
    {
        rb.AddForce(Vector2.up * flapForce);
        Debug.Log("Falan");        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
            gg.GameEnd();

            this.GetComponent<BirdMovement>().enabled = false;
            
            obsSpaw.GetComponent<ObstacleMovement>().enabled = false;

            obsSpaw.GetComponent<ObstacleSpawner>().enabled = false;

            animator.enabled = false;

            scoreTrigger.GetComponent<ObstacleMovement>().enabled = false;


            //scoreTrigger.GetComponent<ObstacleMovement>().enabled = false;

        
    }
}
