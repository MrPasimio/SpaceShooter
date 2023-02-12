using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnControl : MonoBehaviour
{
    public GameObject ship;
    public float delay;
    public bool canSpawn = true;
    public int counter = 0;
    public int spawnMax;

    public void Spawn(int numberToSpawn)
    {
        counter = 0;
        spawnMax = numberToSpawn;
        StartCoroutine(SpawnDelay());
    }

    IEnumerator SpawnDelay()
    {
        Instantiate(ship, transform.position, transform.rotation);
        yield return new WaitForSeconds(delay);
        counter++;
        if(counter < spawnMax)
        {
            StartCoroutine(SpawnDelay());
        }
        

    }
}
