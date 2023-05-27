using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLog : MonoBehaviour
{
    // Start is called before the first frame update
    public MovePlayer movePlayer;
    public float distance; 
    public Transform Probleam;
    public Transform player;
    public void Checkperson(){
        distance = Vector2.Distance(player.transform.position,Probleam.transform.position);
        Debug.Log(distance);
        if (distance < 3){
            movePlayer.locked = true;
            transform.Translate (0.05f, 0f, 0f); 

        }
    }

    // Update is called once per frame
}
