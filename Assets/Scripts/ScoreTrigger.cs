using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    public Score score;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        score.AddScore();
    }

}
