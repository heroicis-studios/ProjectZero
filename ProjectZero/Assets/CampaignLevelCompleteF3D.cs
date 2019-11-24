using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CampaignLevelCompleteF3D : MonoBehaviour
{

    public Transform lvlCompleteUI;

    public void LoadNextLevel()
    {
        Debug.Log(LevelArrays.NextLoadF3D());
    }

    void OnTriggerEnter()
    {
        lvlCompleteUI.gameObject.SetActive(true);   
    }


}
