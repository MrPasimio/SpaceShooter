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

    public Sprite currentSprite;

    public void Spawn(int numberToSpawn)
    {
        counter = 0;
        
        //Randomize the enemy wave;
        if(isHorizontalSpawner)
        {
            int randomInt = Random.Range(0, Hangar.horizontalEnemies.Length);
            Debug.Log("Horizontal Index: " + randomInt);
            currentSprite = Hangar.horizontalEnemies[randomInt];
            Debug.Log("Updated sprite: " + currentSprite.name);
        }else
        {
            int randomInt = Random.Range(0, Hangar.verticalEnemies.Length);
            Debug.Log("Vertical Index: " + randomInt);
            currentSprite = Hangar.verticalEnemies[randomInt];
            Debug.Log("Updated sprite: " + currentSprite.name);
        }

        spawnMax = numberToSpawn;
        StartCoroutine(SpawnDelay());
    }

    IEnumerator SpawnDelay()
    {
        GameObject currentShip = Instantiate(ship, transform.position, transform.rotation);

        if(!isHorizontalSpawner)
        {
            currentShip = currentShip.transform.FindChild("VShip").gameObject;
        }

        Debug.Log("Current Sprite: " + currentSprite.name);
        currentShip.GetComponent<SpriteRenderer>().sprite = currentSprite;

        yield return new WaitForSeconds(delay);
        counter++;
        if(counter < spawnMax)
        {
            StartCoroutine(SpawnDelay());
        }
        

    }
}
