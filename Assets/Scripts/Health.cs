
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 3;
    private int currentHealth;

    private void Start()
    {
        /*
            CLUE:
            Inisialisasi currentHealth agar nilainya sama dengan maxHealth di awal game
        */
        // Tulis kode di sini
    }

    public void TakeDamage(int damage)
    {
        /*
            CLUE:
            Kurangi nilai currentHealth dengan damage yang diterima (currentHealth -= damage)
        */
        // Tulis kode di sini

        Debug.Log(gameObject.name + " HP: " + currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        if (CompareTag("Enemy"))
        {
            LevelManager.instance.AddKill();
        }

        /*
            CLUE:
            Hancurkan objek ini saat HP habis menggunakan fungsi Destroy()
        */
        // Tulis kode di sini
    }
}
