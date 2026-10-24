
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        /*
            CLUE:
            Cek apakah objek yang menabrak memiliki tag "Player" menggunakan CompareTag("Player")
        */
        if (/* Tulis kondisi di sini */)
        {
            if (LevelManager.instance != null)
            {
                LevelManager.instance.AddCoin(coinValue);

                /*
                    CLUE:
                    Hancurkan objek koin ini menggunakan Destroy(gameObject)
                */
                // Tulis kode di sini
            }
        }
    }
}
