
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 3f;

    private Transform player;
    private Rigidbody2D rb;
    private int damage = 1;
    private float nextDamageTime = 0f;

    private void Start()
    {
        /*
            CLUE:
            1. Ambil komponen Rigidbody2D menggunakan GetComponent<Rigidbody2D>() dan simpan ke variabel rb
            2. Cari GameObject player di hierarki dengan GameObject.FindGameObjectWithTag("Player") dan simpan ke variabel playerObject
        */
        // Tulis kode rb di sini

        // Tulis kode playerObject di sini

        if (playerObject != null)
        {
            player = playerObject.transform;
        }
    }

    private void FixedUpdate()
    {
        if (player == null) return;

        Vector2 direction = (player.position - transform.position).normalized;

        /*
            CLUE:
            Gerakkan musuh ke arah player dengan mengatur linearVelocity = direction * moveSpeed
        */
        // Tulis kode di sini
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && Time.time >= nextDamageTime)
        {
            Health health = collision.GetComponent<Health>();

            if (health != null)
            {
                health.TakeDamage(damage);
                nextDamageTime = Time.time + 1f;
            }
        }
    }
}
