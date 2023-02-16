using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * (moveSpeed * Time.deltaTime)); 
    }
}
