using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedDestroy : MonoBehaviour
{
    public float delay;

    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(Suicide), delay);
    }

    private void Suicide()
    {
        Destroy(gameObject);
    }
}
