using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_smoke : MonoBehaviour
{
    // Start is called before the first frame update
    public float size = 1f;
    public float y=15;
    public float x=15;
    public float xplus=1;
    public float yplus=1;
    public Sprite smoke2;
    public Sprite smoke3;
    public Sprite smoke4;
    public Sprite smoke5;
    public Sprite smoke6;
    public Sprite nothing;
    public bool switcher = false;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (switcher){
            StartCoroutine(waiter());
        }
    }
    IEnumerator waiter(){
        this.gameObject.transform.localScale = new Vector3(size, size, 0);
        gameObject.transform.position = new Vector3(x+xplus,y+yplus,-1.0f);
        yield return new WaitForSeconds(0.3f);
        this.gameObject.GetComponent<SpriteRenderer>().sprite = smoke2;
        yield return new WaitForSeconds(0.3f);
        this.gameObject.GetComponent<SpriteRenderer>().sprite = smoke3;
        yield return new WaitForSeconds(0.3f);
        this.gameObject.GetComponent<SpriteRenderer>().sprite = smoke4;
        yield return new WaitForSeconds(0.3f);
        this.gameObject.GetComponent<SpriteRenderer>().sprite = smoke5;
        yield return new WaitForSeconds(0.3f);
        this.gameObject.GetComponent<SpriteRenderer>().sprite = smoke6;
        yield return new WaitForSeconds(0.3f);
        this.gameObject.GetComponent<SpriteRenderer>().sprite = nothing;



    }
}
