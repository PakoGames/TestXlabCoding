using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class GamePlayState : GameState
    {
        public Timer timer;
        public LevelController levelController;

        private void Start()
        {
            Timer.TimeGameOver.AddListener(OnGameOver);
        }

        public GameState gameOverState;
        public GameState gameWinState;
        //public GameState gameWinState;
        private void OnGameOver()
        {
            timer.TimerStop();
            Exit();
            gameOverState.Enter();
        }

    }
}
