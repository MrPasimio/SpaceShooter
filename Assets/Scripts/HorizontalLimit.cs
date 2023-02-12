using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalLimit : MonoBehaviour
{
    public Transform player;
    public Transform leftBorder;
    public Transform rightBorder;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player!=null)
        {
            Debug.Log("Player at " + player.position.x);
            if(player.position.x < leftBorder.position.x)
            {
                player.position = new Vector2(leftBorder.position.x, player.position.y);
            }
            else if (player.position.x > rightBorder.position.x)
            {
                player.position = new Vector2(rightBorder.position.x, player.position.y);
            }
        }
    }
}
