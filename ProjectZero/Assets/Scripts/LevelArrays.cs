using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class LevelArrays
{

    public static int[] F3DScenes;
    public static int[] P3DScenes;
    public static int[] F2DScenes;
    public static int[] P2DScenes;

    public static int NextLoadF3D()
    {
        int currLevel = SceneManager.GetActiveScene().buildIndex;

        for (int i = 0; i < F3DScenes.Length; i++)
        {
            if(currLevel == F3DScenes[i])
            {
                if (i == F3DScenes.Length)
                {
                    return -1;
                }else
                {
                    return F3DScenes[i + 1];
                }
            }
        }
        return -1;
    }   
}
