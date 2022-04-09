using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMechanics : MonoBehaviour
{
    GameObject bluePlayer;
    GameObject purplePlayer;
    GameObject timerObj;
    public float timer;
    public int p1Score;
    public int p2Score;

    // Start is called before the first frame update
    void Start()
    {
        timer = 120.0f;


    }

    // Update is called once per frame
    void Update()
    {

        timer -= Time.deltaTime;

        
        
    }

    public void keepScore(GameObject player) {
        if(player.tag.Equals("Player1")) {
            p1Score = player.GetComponent<PlayerScore>().getScore();
        }
        else {
            p2Score = player.GetComponent<PlayerScore>().getScore();
        }
    }
}
