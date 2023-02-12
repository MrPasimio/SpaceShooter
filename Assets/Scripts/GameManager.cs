using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public SpawnControl[] spawners;
    public float waveDelay;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(nameof(SpawnWave));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnWave()
    {
        spawners[Random.Range(0, spawners.Length)].Spawn(6);
        yield return new WaitForSeconds(waveDelay);
        StartCoroutine(nameof(SpawnWave));
        
    }
}
