using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    #region Metodi Public ----
    //Metodo per avviare la scena del gioco
    public void startGame() {
        SceneManager.LoadScene("Game");    
    }

    //Metodo per uscire dal gioco
    public void exitGame() { 
        Application.Quit();
    }

    #endregion
}
