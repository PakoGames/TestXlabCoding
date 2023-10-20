using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Golf
{


    public class LevelController : MonoBehaviour
    {
        //public Task_3 spawner;
        public GameWinState gameWinState;
        public GamePlayState gamePlayState;

        public bool isGameOver = false;
        public byte rangeMin;
        public byte rangeMax;
        public float rangeStep = 0.1f;
        private float range;
        public int touchCount = 0;
        Hit hit;
        public List<GameObject> levels;
        public  int countLevel = 1;
        //NextLevel nextLevel;


        public int score;
        public int hightScore;

        private float m_lastSpawnedTime = 0;

        private List<GameObject> m_stones = new List<GameObject>(16);

        public void ClearStone()
        {
            foreach (var stone in m_stones)
            {
                Destroy(stone);
            }
            m_stones.Clear();
        }

        void Start()
        {
            m_lastSpawnedTime = Time.time;
            RefreshDelay();

        }
        private void OnEnable()
        {
            GameEvent.onStickHit += OnStickHit;
            score = 0;
            Hit.OnTouch += IncrementTouchCount;
        }

        private void OnDisable()
        {
            GameEvent.onStickHit -= OnStickHit;
            Hit.OnTouch -= IncrementTouchCount;
        }

        private void OnStickHit()
        {
            hightScore = Mathf.Max(hightScore, score);
        }


        private void Update()
        {
            
            if (Time.time >= m_lastSpawnedTime + range)
            {
               // var stone = spawner.SpawnStone();

               // m_stones.Add(stone);
                m_lastSpawnedTime = Time.time;

                RefreshDelay();
                
                
            }
            Nextlevels();
        }
        public void RefreshDelay()
        {
            range = Random.Range(rangeMin, rangeMax);
            range = Mathf.Max(rangeMin, rangeMax - rangeStep);
        }

        private void Nextlevels()
        {
            switch (countLevel)
            {
                case 2:
                    levels[0].SetActive(false);
                    levels[1].SetActive(true);
                    break;
                case 3:
                    levels[1].SetActive(false);
                    levels[2].SetActive(true);
                    break;
                case 4:
                    gameWinState.Enter();
                    gamePlayState.Exit();
                    break;

            }
        }

        private void IncrementTouchCount()
        {
            touchCount++;
            Debug.Log("Touch count: " + touchCount);
        }
    }
}
