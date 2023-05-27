using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using UnityEngine;
public class Cut_trees : MonoBehaviour
{
    // Start is called before the first frame update 
    public Sprite normal;
    public MovePlayer movePlayer;
    public Firecheck firecheck;
    public MoveFire moveFire;
    public Change_smoke change_smoke;
    public float endscale;
    public Transform player;
    public Transform Probleam;
    public float distance; 
    public float size; 
    private float xPos; 
    private float yPos;
    public float xplus;
    public float yplus;
    public void Checkperson(){
        distance = Vector2.Distance(player.transform.position,Probleam.transform.position);
        if (distance < 3){
            firecheck.done += 1;
            StartCoroutine(waiter());
        }
    }
    void Start(){
        float xPos = gameObject.transform.position.x;
        float yPos = gameObject.transform.position.y;
        moveFire.x = xPos;
        moveFire.y = yPos;
    }

    IEnumerator waiter()
{
    float xPos = gameObject.transform.position.x;
    float yPos = gameObject.transform.position.y;
    moveFire.safe = true;
    movePlayer.locked = true;
    Debug.Log(xPos);
    Debug.Log(yPos);
    change_smoke.size = size;
    change_smoke.x = xPos;
    change_smoke.y = yPos;
    change_smoke.xplus = xplus;
    change_smoke.yplus = yplus;
    change_smoke.switcher = true;
    yield return new WaitForSeconds(0.001f);
    change_smoke.switcher = false;
    this.transform.localScale = new Vector3(endscale, endscale, 1f);
    this.gameObject.GetComponent<SpriteRenderer>().sprite = normal;
    yield return new WaitForSeconds(1.8f);
    movePlayer.locked = false;
    

}
}

