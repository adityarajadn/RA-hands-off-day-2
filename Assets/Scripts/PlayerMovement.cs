using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody2D rb;
    private float horizontal;
    private float vertical;

    private void Start()
    {
        /*
            CLUE:
            Ambil komponen Rigidbody2D pada GameObject ini menggunakan GetComponent<Rigidbody2D>()
            dan simpan ke variabel rb.
        */
        // Tulis kode di sini
    }

    private void Update()
    {
        /*
            CLUE:
            1. Beri value Input.GetAxisRaw("Horizontal") pada variabel horizontal
            2. Beri value Input.GetAxisRaw("Vertical") pada variabel vertical
        */
        // Tulis kode di sini
    }

    private void FixedUpdate()
    {
        Vector2 movement = new Vector2(horizontal, vertical).normalized;

        /*
            CLUE:
            Gerakkan Rigidbody2D dengan mengatur linearVelocity = movement * moveSpeed
        */
        // Tulis kode di sini
    }
}
