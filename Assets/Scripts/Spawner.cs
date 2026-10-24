
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Spawn Settings")]
    [SerializeField] private GameObject prefab;
    [SerializeField] private Transform target;
    [SerializeField] private float spawnRadius = 5f;
    [SerializeField] private float spawnInterval = 2f;

    private float spawnTimer;

    private void Update()
    {
        if (prefab == null || target == null)
        {
            return;
        }

        spawnTimer += Time.deltaTime;

        if (spawnTimer >= spawnInterval)
        {
            SpawnPrefab();
            spawnTimer = 0f;
        }
    }

    private void SpawnPrefab()
    {
        Vector2 randomOffset = Random.insideUnitCircle * spawnRadius;

        /*
            CLUE:
            Buat posisi spawn baru bertipe Vector3 dengan menambahkan koordinat target dan randomOffset:
                - x: target.position.x + randomOffset.x
                - y: target.position.y + randomOffset.y
                - z: target.position.z
            Simpan hasilnya ke variabel: Vector3 spawnPosition
        */
        // Tulis kode di sini

        /*
            CLUE:
            Munculkan prefab pada spawnPosition dengan rotasi default (Quaternion.identity)
            menggunakan fungsi Instantiate().

            Catatan Quaternion:
            - Quaternion adalah struktur data di Unity untuk merepresentasikan dan menghitung rotasi.
            - Quaternion.identity artinya "tanpa rotasi" / sudut rotasi (0, 0, 0), mengikuti rotasi default prefab.
        */
        // Tulis kode di sini
    }
}
