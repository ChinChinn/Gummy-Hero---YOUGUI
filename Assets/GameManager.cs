using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour{
    public bool isPlaying;
    // is playing == falso que cuando deje el menu deje de spawwnearr
    // is playing - true lo contrario al primero cuando ya no haiga menu

    public void Start(){
        changeGameStatus(false);
    }
    public void changeGameStatus(bool status){
        isPlaying = status;
    }

    public bool getGameStatus(){
        return isPlaying;
    }

    public void gameOver(){
        StartCoroutine("RestartGameScene");
    }

    IEnumerator RestartGameScene(){
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("TestScene");
    }
}

    
