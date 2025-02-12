using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Health : MonoBehaviour
{
    public GameObject DiePrefab;
    public int defaultHealthPoint;
    private int healthPoint;
    private void Start()
    {
        healthPoint = defaultHealthPoint;
    }
    public void OnTriggerEnter2D(Collider2D collision) => Die();

    protected virtual void Die()
    {
        var explosion = Instantiate(DiePrefab, transform.position, transform.rotation);
        Destroy(explosion, 1);
        Destroy(gameObject);
    }
    public void TakeDamage(int damage)
    {
        if (healthPoint <= 0) return;

        healthPoint -= damage;
        if (healthPoint <= 0) Die();
    }

}

