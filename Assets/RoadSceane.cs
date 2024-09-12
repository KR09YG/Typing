using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
using UnityEngine.UI;

public class RoadSceane : MonoBehaviour
{
    [SerializeField] float changeTime;
    [SerializeField] Animator zombie;
    //[SerializeField] Image image;
    public void SceaneChanger()
    {
        
        Invoke("SceaneMain", changeTime);
        Invoke("ToWeen", changeTime-2f);
        zombie.Play("atack2");
    }

    void TWeen()
    {
       // image.DOFade(1.5f, 0f);
    }

    void SceaneMain()
    {
        SceneManager.LoadScene("Main");
    }

}
