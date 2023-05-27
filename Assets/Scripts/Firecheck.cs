using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Firecheck : MonoBehaviour
{
    // Start is called before the first frame update
    public int done = 0;
    public int max;
    public GameObject victoryScreen;
    public GameObject defeatScreen;
    public Cut_trees cut_trees;
    void Start()
    { 
        victoryScreen.SetActive(false);
        defeatScreen.SetActive(false);
    }

    // Update is called once per frame
    public void check()
    {
        Debug.Log(done);
        if (done == max){
            victoryScreen.SetActive(true);
            }
        else{
        defeatScreen.SetActive(true);
        }
    }
}
