using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Manager : MonoBehaviour
{   
    public GameObject levelWonUI;

    public float delay=1f;
    bool ended=false;
    public void Endgame(){
        if(ended==false){
            ended=true;
            Debug.Log("GAME OVER");
            Invoke("Restart",delay);
        }
    }

    public void CompleteLvl(){
        levelWonUI.SetActive(true);
    }

    void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
