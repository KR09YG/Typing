using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSystem : MonoBehaviour
{
    [SerializeField] Text _tttext;
    [SerializeField] Text _tttext2;
    Timer _timer;
    EnemyWard enemyWard;
    public bool swich = false;
    float timer = 0;
    bool good = false;
    float hp = 100;
    float maxHp = 100;
    Slider slider;
    private void Start()
    {
        slider = GameObject.Find("Slider").GetComponent<Slider>();
        _timer = GameObject.Find("GameManager").GetComponent<Timer>();
        enemyWard = GameObject.FindGameObjectWithTag("enemy").GetComponent<EnemyWard>();
        Debug.Log(enemyWard.ward);
    }
    public void InputSystem(string text)
    {
        if (text == enemyWard.ward)
        {
            Debug.Log("a");
            good = true;
            swich = true;
            _tttext.text = "¬Œ÷";
            hp -= 10;
        }
        else
        {
            _timer._timer -= 3;
            good = true;
            _tttext.text = "Ž¸”s";
        }
        _tttext2.text = "";
        Debug.Log(hp);
    }
    private void Update()
    {
        slider.value = hp / maxHp;
        timer += Time.deltaTime;
        if (good == true)
        {
            timer = 0;
            good = false;
            _tttext.enabled = true;
        }
        if ( timer > 1 )
        {
            _tttext.enabled = false;
        }
    }
}
