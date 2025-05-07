using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonatSpawnerScript : MonoBehaviour
{
    public GameObject[] donutPrefabs;
    public float spawnInterval = 1f;
    public bool state = true;

    private float minPoz, maxPoz;
    private Transform ovenPozition;

    private void Start()
    {
        ovenPozition = GetComponent<Transform>();

        if (state)
            StartCoroutine(BakeDonutCoroutine());
    }

    public void BakeDonut(bool state)
    {
        if (state)
            StartCoroutine(BakeDonutCoroutine());
        else
            StopAllCoroutines();
    }

    private IEnumerator BakeDonutCoroutine()
    {
        while (true)
        {
            minPoz = ovenPozition.position.x - 30f;
            maxPoz = ovenPozition.position.x + 30f;

            float randomX = Random.Range(minPoz, maxPoz);
            Vector2 spawnPosition = new Vector2(randomX, ovenPozition.position.y);

            GameObject donut = Instantiate(
                donutPrefabs[Random.Range(0, donutPrefabs.Length)],
                spawnPosition,
                Quaternion.identity,
                ovenPozition
            );

            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
