using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] Text _timeText;
    [SerializeField] public float _timer = 60f;
    
    void Update()
    {
        _timer -= Time.deltaTime;
        _timeText.text = _timer.ToString("F2");
        if ( _timer < 0)
        {
            Time.timeScale = 0;
        }
    }
}
