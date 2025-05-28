using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointManager : MonoBehaviour
{
    Vector3 savedPosition, savedRotation;
    public Transform playerModel;
    public void Awake()
    {
        SaveTransform(transform.position, transform.eulerAngles);
    }
    private void SaveTransform(Vector3 checkpointPosition, Vector3 checkpointRotation)
    {
        savedPosition = checkpointPosition;
        savedRotation = checkpointRotation;
    }
    public void LoadLastCheckpoint()
    {
        transform.position = savedPosition;
        playerModel.eulerAngles = savedRotation;


    }

    // Update is called once per frame
    private void OntriggerEnter()
    {
        
    }
}
