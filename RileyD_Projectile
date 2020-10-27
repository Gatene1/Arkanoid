using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RileyD_Projectile : MonoBehaviour{
    [SerializeField]
    RileyD_Plank plank;
    Vector3 plankToProjectile;
    Rigidbody2D thisRB;
    bool bHasStarted = false;

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (RileyD_Options.gamePlayMode == 2)
        {
            Vector2 velChange = new Vector2(Random.Range(-2.5f, 2.5f), Random.Range(0.0f, 0.2f));
            thisRB.velocity += velChange;
        }
        else if (RileyD_Options.gamePlayMode == 0 && coll.gameObject.name == "Plank")
            resetProjectile();

        
    } 

    // Use this for initialization
    void Start(){
        plankToProjectile = this.transform.position - plank.transform.position;
        thisRB = gameObject.GetComponent<Rigidbody2D>();
    }

    public void resetProjectile()
    {
        bHasStarted = false;
    }


    // Update is called once per frame
    void Update(){
        if (!bHasStarted)
        {
            this.transform.position = plank.transform.position + plankToProjectile;
            if (Input.GetMouseButton(0))
            {
                thisRB.velocity = new Vector2(1.5f, 12f);
                bHasStarted = true;
            }
        }
    }
}
