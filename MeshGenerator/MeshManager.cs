using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshManager : MonoBehaviour
{
    GeneratePlanet generatePlanet;
    [HideInInspector]
    public float spawnPoint;
    // Start is called before the first frame update
   
    void Start()
    {
        generatePlanet = GetComponent<GeneratePlanet>();
        generatePlanet.CreatePlanet();
        spawnPoint = generatePlanet.planetSize;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
