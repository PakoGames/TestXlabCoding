using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

namespace Golf
{
    public class Timer : MonoBehaviour
    {
        public TMP_Text timerText;
        private float startTime;
        private bool timerIsRunning = false;
        public static UnityEvent TimeGameOver = new UnityEvent();
        int t
            , minutes
            , seconds;


        void Start()
        {
            timerText.text = "Time: 0.00";
            startTime = Time.time;
        }

        void Update()
        {
            if (timerIsRunning)
            {
                 t = (int)(Time.time - startTime);

                 minutes = ((int)t / 60);
                 seconds = (t % 60);

                timerText.text = "Time: " + minutes + ":" + seconds;
                if (minutes > 3)
                {
                    timerIsRunning = false;
                    StopGame();
                }
            }
        }

        private void StopGame()
        {
            TimeGameOver?.Invoke();
        }

        public void TimerStart()
        {
            timerIsRunning = true;
        }

        public void TimerStop()
        {
            timerIsRunning = false;
        }
    }
}
