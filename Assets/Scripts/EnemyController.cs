using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        
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
            Instantiate(explosion, transform.position, explosion.transform.rotation);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
