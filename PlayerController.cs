using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private Vector2 targetPos;
    public float Yinc;
    public float speed;
    public float maxH;
    public float minH;
    public int health = 3;
    public GameObject effect;
    public Text Healthdisp;
    public GameObject gameOver;
    public GameObject popsound;

    void Update()
    {
        Healthdisp.text = health.ToString();
        if (health <= 0)
        {
            gameOver.SetActive(true);
            Destroy(gameObject);
        }
        transform.position = Vector2.MoveTowards(transform.position,targetPos,speed*Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxH)
        {
            Instantiate(popsound, transform.position, Quaternion.identity);
            Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y+Yinc);

            
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minH)
        {
            Instantiate(popsound, transform.position, Quaternion.identity);
            Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y - Yinc);
            
        }
        
    }
}
