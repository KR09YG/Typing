using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    GameObject _enemy;

    private void Start()
    {
        _enemy = GameObject.FindGameObjectWithTag("enemy").GetComponent<GameObject>();
    }
    public void TestA(string text)
    {
        if (text == "‚è‚ñ‚²")
        {
            _enemy.SetActive(false);
        }
    }

    void Update()
    {
        
    }
}
