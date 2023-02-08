using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum States { START, PLAYERTURN, ENEMYTURN, WON, LOST }
public class BattleSystem : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject playerPrefab;
    public GameObject enemyPrefab;
    
    public Transform playerBattleStation;
    public Transform enemyBattleStation;

    public States state;
    void Start()
    {
        state = States.START;
        SetupBattle();
    }

    void SetupBattle()
    {
        Instantiate(playerPrefab, playerBattleStation);
        Instantiate(enemyPrefab, enemyBattleStation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
