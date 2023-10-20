using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Golf
{
    public class MainMenuState : GameState
    {
        public Timer timer;
        public GameState gamePlayState;

        public void PlayGame()
        {
            timer.TimerStart();
            Exit();
            gamePlayState.Enter();
        }

        protected override void OnEnable()
        {
            base.OnEnable();

        }
    }
}
