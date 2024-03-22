using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HandPrescence : MonoBehaviour
{
    public InputDeviceCharacteristics controllerChar;
    public GameObject handModelPrefab;

    private InputDevice targetDevice;
    private GameObject spawnedHandModel;

    // Start is called before the first frame update
    void Start()
    {
        spawnedHandModel = Instantiate(handModelPrefab, transform);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
