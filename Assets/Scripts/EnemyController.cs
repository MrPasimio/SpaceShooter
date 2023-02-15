using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public GameObject explosion;
    public int value;
    public GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger!");
        if(collision.CompareTag("PlayerBullet"))
        {
            Debug.Log("Hit by Bullet");
            gm.AddScore(value);
            Instantiate(explosion, transform.position, explosion.transform.rotation);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
