using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class EnemyWard : MonoBehaviour
{
    [SerializeField] Text text;
    GameSystem gameSystem;
    public string ward;
    public int rand = 0;
    public float timer = 0;
    [SerializeField] float playtiming = 1f;
    [SerializeField] string[] gameWard;
    [SerializeField] string[] easyWard;
    [SerializeField] Animator _zombieAnimator;
    [SerializeField] Animator _textAnim;
    void Start()
    {
        gameSystem = GameObject.Find("GameManager").GetComponent<GameSystem>();
        rand = Random.Range(0, easyWard.Length);
        Debug.Log(rand);
    }
    private void Update()
    {
        timer += Time.deltaTime;
        Debug.Log(timer);
        if (gameSystem.count <= 9)
        {
            ward = easyWard[rand];
        }
        else if (gameSystem.count > 9)
        {
            ward = gameWard[rand];
        }
        text.text = ward;

        if (gameSystem.swich == true)
        {
            if (timer > playtiming)
            {
                _textAnim.Play("SizeUp");
                //_zombieAnimator.Play("atack1");
                if (gameSystem.count <= 9)
                {
                    Debug.Log("aaaaaaaa");
                    ward = easyWard[rand];
                    rand = Random.Range(0, easyWard.Length);
                    gameSystem.swich = false;
                }
                else if (gameSystem.count > 9)
                {
                    Debug.Log("bbbbbbbb");
                    ward = gameWard[rand];
                    rand = Random.Range(0, gameWard.Length);
                    gameSystem.swich = false;
                }
            }

            //Debug.Log(ward);
            //Debug.Log(rand);

        }

    }

}
