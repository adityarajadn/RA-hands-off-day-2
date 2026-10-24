
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 10f;
    public float lifeTime = 3f;
    public int damage = 1;

    private void Start()
    {
        /*
            CLUE:
            Hancurkan peluru (gameObject) secara otomatis setelah durasi "lifeTime" menggunakan Destroy()
        */
        // Tulis kode di sini
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        /*
            CLUE:
            Gerakkan peluru maju ke atas lokal menggunakan:
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        */
        // Tulis kode di sini
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Health health = collision.GetComponent<Health>();

            if (health != null)
            {
                health.TakeDamage(damage);
            }

            /*
                CLUE:
                Hancurkan peluru (gameObject) saat menabrak musuh
            */
            // Tulis kode di sini
        }
    }

}
