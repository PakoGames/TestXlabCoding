using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Golf
{
    public class GameWinState : GameState
    {

        public GameState mainMenuState;

        public void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Exit();
            mainMenuState.Enter();
        }

    }
}
