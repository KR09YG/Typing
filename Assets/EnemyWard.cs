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
    string[] gameWard = {"apple","bus","car","drop","end","find","good","hand","idea","jet","king","land","main","need","oil","paint","quit"};
    void Start()
    {
        gameSystem =GameObject.Find("GameManager").GetComponent<GameSystem>();
        int rand = Random.Range(0, gameWard.Length - 1);
        ward = gameWard[rand];        
    }
    private void Update()
    {
        if ( gameSystem.swich == true )
        {
            int rand = Random.Range(0, gameWard.Length );
            ward = gameWard[rand];
            gameSystem.swich = false;
            Debug.Log(ward);
        }
        text.text = ward;
    }

}
