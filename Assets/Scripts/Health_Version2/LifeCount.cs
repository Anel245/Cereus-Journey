using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeCount : MonoBehaviour
{
    public Image[] lives;
    public int livesRemaining;

    //4 lives - 4 images (0,1,2,3)
    //3 lives - 3 images (0,1,2,[3])
    //2 lives - 2 images (0,1,[2],[3])
    //1 life - 1 image (0,[1],[2],[3])
    //0 lives - 0 images ([0],[1],[2],[3]) LOSE

    public void LoseLife()
    {
        //Decrease the value of livesRemaining
        livesRemaining--;
        //Hide one of the life image
        lives[livesRemaining].enabled = false;

     
        // If we run out lives we lose the game
        if(livesRemaining==0)
        {
            PlayerManager.isGameOver = true;
            gameObject.SetActive(false);
        }

    }

    private void Update()
    {

    }
}
