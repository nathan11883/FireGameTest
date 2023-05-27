using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFire : MonoBehaviour
{
    public float y;
    public float x;
    public bool safe = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void fireclicked()
    {
        Debug.Log(x);
        Debug.Log(y);
        if (!safe){
            Debug.Log("notdone");
            gameObject.transform.position = new Vector3(x,y,-0.9f);
        }
    }
}
