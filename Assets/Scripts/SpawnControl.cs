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

    public bool isHorizontalSpawner;

    public void Spawn(int numberToSpawn)
    {
        counter = 0;
        
        //Randomize the enemy wave;
        if(isHorizontalSpawner)
        {
            ship.GetComponent<SpriteRenderer>().sprite = Hangar.horizontalEnemies[Random.Range(0, Hangar.horizontalEnemies.Length)];
        }else
        {
            ship.GetComponent<SpriteRenderer>().sprite = Hangar.verticalEnemies[Random.Range(0, Hangar.verticalEnemies.Length)];
        }

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
