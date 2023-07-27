using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.PlayerLoop;
using System;

public class Bomb : MonoBehaviour
{
    public float score;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);


        if (collision.gameObject.TryGetComponent<Enemy>(out Enemy enemyComponet))
        {
            enemyComponet.TakeDamage(1);
        }

        Destroy(gameObject);

        if (collision.gameObject.GetComponent<Enemy>() != null)
        { // Check if an object is an Enemy

            score++;
        }

    }


}