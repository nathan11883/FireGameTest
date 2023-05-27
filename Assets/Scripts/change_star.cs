using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class change_star : MonoBehaviour
{
    // Start is called before the first frame update
    public int found =0;
    public Sprite star1;
    public Sprite star2;
    public Sprite star3;
    public Sprite star4;
    void Awake()
    {
        found=0;
        //scut_trees.GetComponent<Cut_trees>;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(found);
        if (found == 1){
            Debug.Log("SAS");
            this.gameObject.GetComponent<SpriteRenderer>().sprite = star1;
            Debug.Log("SAS");
        }
        if (found == 2){
            this.gameObject.GetComponent<SpriteRenderer>().sprite = star2;
        }
        if (found == 3){
            this.gameObject.GetComponent<SpriteRenderer>().sprite = star3;
        }
        if (found == 4){
            this.gameObject.GetComponent<SpriteRenderer>().sprite = star4;
        }
    }
}
