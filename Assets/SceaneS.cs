using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;

public class SceaneS : MonoBehaviour
{
    [SerializeField] float changeTime;
    [SerializeField] Animator zombie;
    public void SceaneChanger()
    {
        
        Invoke("SceaneMain", changeTime);
        Invoke("ToWeen", changeTime - 2f);
        zombie.Play("atack2");
    }

    

    void SceaneMain()
    {
        SceneManager.LoadScene("MainStation");
    }
}
