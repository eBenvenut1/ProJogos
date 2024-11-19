using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SLIDESSC : MonoBehaviour
{
    [SerializeField] private string nomeDoSlide;
    
    public void slide1(){
        SceneManager.LoadScene(nomeDoSlide);

    }

    public void sair(){
        Application.Quit();
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
