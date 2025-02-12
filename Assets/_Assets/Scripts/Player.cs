using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float move;
    public Rigidbody2D rb;
    public float speed = 10f;
    public int damage;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(speed * move, rb.velocity.y);


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var enemy = collision.GetComponent<EnemyHealth>();
       
        Destroy(gameObject);
    }


}
