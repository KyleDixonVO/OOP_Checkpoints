using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class KillBox : MonoBehaviour
{
    public Transform respawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetCheckpoint();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.transform.position = respawnPoint.transform.position;
        }
    }
    
    private void GetCheckpoint()
    {
        
    }
}
