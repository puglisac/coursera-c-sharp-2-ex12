using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncer : MonoBehaviour
{
    int health = 100;

    int Health { get { return health; } }

    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb2d = GetComponent<Rigidbody2D>();
        rb2d.AddForce(new Vector2(50, 100));
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        health -= 10;

        Color spriteColor = spriteRenderer.color;
        spriteColor.a -= 0.1f;
        spriteRenderer.color = spriteColor;

        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }

}
