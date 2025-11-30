using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Klaud : MonoBehaviour
{
    public float ptica;
    public float klaud;
    public GameObject GameOverUI;
    public static bool gameispaused = false;
    public Vector2 offset;
    public float kaktus=0;
	public float Velocity;

    Vector2 pos;
    void Start()
    {
        Velocity =-0.01f;
        pos = new Vector2(transform.position.x, transform.position.y);
    }
    void Update()
    {
		
        if (gameispaused == false&& kaktus== 0&&ptica==0)
        pos += new Vector2(Velocity, 0);
        if (gameispaused == false && kaktus == 0&&ptica==1)
            pos += new Vector2(-0.35f, 0);
         if (pos.x <= -35    &&ptica==0)
        {
            pos = new Vector2(transform.position.x + 57.84f + Random.Range(offset.x,offset.y), transform.position.y);
        }
        else if(pos.x <= -26 && ptica ==1)
        {
            pos = new Vector2(transform.position.x + 70.84f + Random.Range(offset.x, offset.y), transform.position.y-transform.position.y+Random.Range(-2,2));
        }
        else if(pos.x <= -26 && klaud ==1)
        {
            pos = new Vector2(transform.position.x + 70.84f + Random.Range(offset.x, offset.y), transform.position.y);
        }

        transform.position = pos;
		
    }
}