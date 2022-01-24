using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints : MonoBehaviour
{
    public Transform checkpointPosition;
    public Material Active;
    public Material Inactive;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (gameObject.CompareTag("Player"))
        {
            
            GameObject[] checkpoints = GameObject.FindGameObjectsWithTag("Checkpoints");
            foreach (GameObject checkpoint in checkpoints)
            {
                GetComponent<MeshRenderer>().material = Inactive;
            }
            this.GetComponent<MeshRenderer>().material = Active;
        }
    }
}
