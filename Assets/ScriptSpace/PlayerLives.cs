using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerLives : MonoBehaviour
{

    public int lives = 3;
    public Image[] livesUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.gameObject.tag == "Enemy")
        {
            Destroy(collision.collider.gameObject);
            lives -=1;
            for(int i = 0;i < livesUI.Length; i++){
                if(i<lives){
                    livesUI[i].enabled = true;
                }
                else{
                    livesUI[i].enabled = false;
                }
            }
            if(lives <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag == "Enemy Projectile")
        {
            Destroy(collision.gameObject);
            lives -=1;
            for(int i = 0;i < livesUI.Length; i++){
                if(i<lives){
                    livesUI[i].enabled = true;
                }
                else{
                    livesUI[i].enabled = false;
                }
            }
            if(lives <= 0)
            {
                Destroy(gameObject);
                SceneManager.LoadScene("Slide6");
            }
        }
    }

}
