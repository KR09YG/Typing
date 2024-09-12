using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows;

public class GameSystem : MonoBehaviour
{

    [SerializeField] string[] trueWard;
    [SerializeField] string[] trueWard2;
    Timer _timer;
    float time;
    EnemyWard enemyWard;
    public bool swich = false;
    float timer = 0;
    bool good = false;
    float hp = 100;
    float maxHp = 100;
    public int count = 0;
    Slider slider;
    [SerializeField] InputField nameInputField;
    [SerializeField] Animator textAnimator;
    [SerializeField] GameObject bomb;
    [SerializeField] Animator zombie;
    [SerializeField] Text trueText;
    [SerializeField] Text text;
    [SerializeField] GameObject text2;
    [SerializeField] GameObject inputF;
    [SerializeField] GameObject button;
    [SerializeField] GameObject image;
    [SerializeField] Text timertext;
    float imatimer;
    [SerializeField] AudioSource audiosouce;
    [SerializeField] AudioSource audiosouce2;
    [SerializeField] AudioSource audiosouce3;
    [SerializeField] GameObject bGM;
    [SerializeField] GameObject bGM1;

    private void Start()
    {
        slider = GameObject.Find("Slider").GetComponent<Slider>();
        _timer = GameObject.Find("GameManager").GetComponent<Timer>();
        enemyWard = GameObject.FindGameObjectWithTag("enemy").GetComponent<EnemyWard>();
        trueText.enabled = false;
        text2.SetActive(false);
        button.SetActive(false);
    }
    public void InputSystem(string text)
    {
        nameInputField.text = "";
        Debug.Log(count);
        Debug.Log(enemyWard.rand);
        if (count <= 9)
        {
            if (text == trueWard2[enemyWard.rand])
            {
                trueText.enabled = false;
                time = 0;
                textAnimator.Play("TextAnimSizeDown");
                bomb.SetActive(true);
                zombie.Play("gethit");
                audiosouce.Play();
                audiosouce2.Play();
                count++;
                good = true;
                hp -= 5;
                //swich = true;
            }
            else if (text != trueWard2[enemyWard.rand])
            {
                trueText.enabled = true;
                _timer._timer -= 3;
                //good = true;
            }
        }
        else if (count > 9)
        {
            if (text == trueWard[enemyWard.rand])
            {
                trueText.enabled = false;
                time = 0;
                textAnimator.Play("TextAnimSizeDown");
                bomb.SetActive(true);
                audiosouce.Play();
                audiosouce2.Play();
                zombie.Play("gethit");
                Debug.Log("a");
                good = true;
                //swich = true;
                hp -= 5;
            }
            else
            {
                trueText.enabled = true;
                _timer._timer -= 3;
                //good = true;
            }
        }

    }

    private void Update()
    {
        imatimer += Time.deltaTime;
        if (imatimer > 5f)
        {
            image.SetActive(false);
        }
        Debug.Log(imatimer);
        if (count <= 9)
        {
            trueText.text = trueWard2[enemyWard.rand];
        }
        else
        {
            trueText.text = trueWard[enemyWard.rand];
        }

        Debug.Log(good);
        time += Time.deltaTime;
        slider.value = hp / maxHp;
        timer += Time.deltaTime;

        if (good == true && time > 1)
        {
            enemyWard.timer = 0f;
            swich = true;
            audiosouce3.Play();
            bomb.SetActive(false);
            good = false;
        }

        if (hp <= 0)
        {
            bGM.SetActive(false);
            bGM1.SetActive(true);
            inputF.SetActive(false);
            gameObject.SetActive(false);
            timertext.enabled = false;
            text.enabled = false;
            Invoke("TextTiming", 3f);
            zombie.Play("death2");
        }

    }

    private void TextTiming()
    {
        text2.SetActive(true);
        button.SetActive(true);
    }
}
