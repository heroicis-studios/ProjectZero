using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelArraysQuickSetup : MonoBehaviour
{

    public int[] F3DQuickSetup;

    // Start is called before the first frame update
    void Start()
    {
        LevelArrays.F3DScenes = F3DQuickSetup;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
