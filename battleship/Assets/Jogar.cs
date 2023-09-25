using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jogar : MonoBehaviour
{
    [SerializeField] private string level1;
    [SerializeField] private GameObject painelMenu;

    public void jogar()
    {
        SceneManager.LoadScene(level1);
    }

    public void sair()
    {
        Application.Quit();
        Debug.Log("Você saiu do jogo");
    }

}