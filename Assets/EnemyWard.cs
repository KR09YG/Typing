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
    [SerializeField] string[] gameWard;
    [SerializeField] string[] easyWard;
    void Start()
    {
        gameSystem = GameObject.Find("GameManager").GetComponent<GameSystem>();
        rand = Random.Range(0, gameWard.Length);
        
        Debug.Log(rand);
    }
    private void Update()
    {
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
            if (gameSystem.count <= 9)
            {
                Debug.Log("aaaaaaaa");
                ward = easyWard[rand];
            }
            else if (gameSystem.count > 9)
            {
                Debug.Log("bbbbbbbb");
                ward = gameWard[rand];
            }
            Debug.Log(ward);
            rand = Random.Range(0, gameWard.Length);
            gameSystem.swich = false;
            Debug.Log(rand);
        }
        
    }

}
