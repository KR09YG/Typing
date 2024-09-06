using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RoadSceane : MonoBehaviour
{
    [SerializeField] Button button;
    void Start()
    {
        button.onClick.AddListener(() => SceneManager.LoadScene("Main"));
    }

}
