using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIfNear : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public Transform Probleam;
    public float distance; 

    public void Checkperson(GameObject obj){
        distance = Vector2.Distance(player.transform.position,Probleam.transform.position);
        Debug.Log(distance);
        if (distance < 3)
            obj.SetActive(false);
    }

}
