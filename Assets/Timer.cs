using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] Text _timeText;
    [SerializeField] public float _timer = 60f;
    [SerializeField] public float _startTimer;
    [SerializeField] Animator _animator;
    [SerializeField] Text text;
    [SerializeField] Text text1;
    [SerializeField] Text text2;
    [SerializeField] Text text3;
    [SerializeField] GameObject gameObject1;
    [SerializeField] GameObject gameObject2;
    [SerializeField] GameObject gameObject3;
    [SerializeField] AudioSource audioSource1;
    [SerializeField] AudioSource audioSource2;

    
    void FixedUpdate()
    {
        _startTimer += Time.deltaTime;
        if (_startTimer > 2f)
        {
            _timer -= Time.deltaTime;
            _timeText.text = _timer.ToString("F2");
            if (_timer < 0)
            {
                text.enabled = false;
                text1.enabled = false;
                text2.enabled = false;
                text3.enabled = false;
                gameObject1.SetActive(false);
                gameObject2.SetActive(false);
                gameObject3.SetActive(false);
                audioSource1.Play();
                Invoke("Voice", 2f);
                _animator.Play("roar");
                Invoke("GameOver", 4f);
                _timer = 1000;
            }
        }
    }

    void GameOver()
    {
        SceneManager.LoadScene("GameOverSceane");
    }

    void Voice()
    {
        audioSource2.Play();
    }
}
