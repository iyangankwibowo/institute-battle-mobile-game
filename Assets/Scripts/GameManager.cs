
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	  public bool gameHasEnded = false;



    public float restart= 1f;

        public void EndGame() {
       
        if (gameHasEnded == false) {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restart);
        
        }
        
    }

    void Restart() {
       
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
