using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
  public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void EscenaJuego()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void Configuraciones()
    {
        SceneManager.LoadScene("Opciones");
    }


    public void Salir()
    {
        Application.Quit();
    }
}

