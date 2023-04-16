using UnityEngine;
using UnityEngine.SceneManagement;

public class EndofLevel : MonoBehaviour
{
    public Game_Manager gameManager;
    bool fix = false;

    void OnTriggerEnter() {
        if(fix==false){
            fix=true;
        }
        else if(fix==true){
            gameManager.CompleteLvl();
            Invoke("LoadNextLvl",1f);
        }
        
        
    }

    public void LoadNextLvl(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
