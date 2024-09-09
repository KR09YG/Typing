using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSystem : MonoBehaviour
{
    [SerializeField] Text _successText;
    [SerializeField] Text _missText;
    [SerializeField] string[] trueWard;
    [SerializeField] string[] trueWard2;
    Timer _timer;
    EnemyWard enemyWard;
    public bool swich = false;
    float timer = 0;
    bool good = false;
    float hp = 100;
    float maxHp = 100;
    public int count = 0;
    Slider slider;
    private void Start()
    {
        slider = GameObject.Find("Slider").GetComponent<Slider>();
        _timer = GameObject.Find("GameManager").GetComponent<Timer>();
        enemyWard = GameObject.FindGameObjectWithTag("enemy").GetComponent<EnemyWard>();
    }
    public void InputSystem(string text)
    {
        Debug.Log(count);
        Debug.Log(enemyWard.rand);
        if (count <= 9)
        {
            if (text == trueWard2[enemyWard.rand])
            {
                count++;
                good = true;
                swich = true;
                _successText.text = "¬Œ÷";
                hp -= 5;
            }
            else
            {
                _timer._timer -= 3;
                good = true;
                _successText.text = "Ž¸”s";
            }
        }
        else if (count > 9) 
        {
            if (text == trueWard[enemyWard.rand])
            {
                Debug.Log("a");
                good = true;
                swich = true;
                _successText.text = "¬Œ÷";
                hp -= 5;
            }
            else
            {
                _timer._timer -= 3;
                good = true;
                _successText.text = "Ž¸”s";
            }
        }
            _missText.text = "";
        
    }

    private void Update()
    {
        slider.value = hp / maxHp;
        timer += Time.deltaTime;
        if (good == true)
        {
            timer = 0;
            good = false;
            _successText.enabled = true;
        }

        if (timer > 1)
        {
            _successText.enabled = false;
        }
    }
}
