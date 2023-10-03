using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task_3_Rain_Run : MonoBehaviour
{
    
    public Task_3_Rain MyPath;
    public float speed = 1;
    public float maxDistance = .1f;
    private Vector3 point;
    public GameObject Rain;



    private IEnumerator<Transform> pointInPath;

    // Start is called before the first frame update
    void Start()
    {
        if (MyPath == null)
        {
            Debug.Log("Ошибка, вы забыли прикрепить путь.");
            return;
        }

        pointInPath = MyPath.GetNextPathPoint();// обращение к коротину GetNextPathPoint

        pointInPath.MoveNext();// Получение следующей точки в пути

        if (pointInPath.Current == null)
        {
            Debug.Log("Нужны точки");
            return;
        }
        point = new Vector3(pointInPath.Current.position.x, 50, pointInPath.Current.position.z);
        transform.position = point;
    }

    // Update is called once per frame
    void Update()
    {
        #region Код отвечающий за передвижение и позицию облака
        if (pointInPath == null || pointInPath.Current == null)
        {
            return;
        }
        point = new Vector3(pointInPath.Current.position.x, 50, pointInPath.Current.position.z);
        transform.position = Vector3.MoveTowards(transform.position, point, Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Z))
        {

            var distanceSqure = (transform.position - point).sqrMagnitude; // Проверка, достаточно ли мы близко к точке, чтобы двигаться к следующей точке
            if (distanceSqure < maxDistance * maxDistance) //Достаточно ли мы близко по теореме Пифагора
            {
                pointInPath.MoveNext();


            }

        }
        #endregion

        #region Код отвечающий за вкл/выкл дождя
        if (transform.position == point)
        {
            Rain.SetActive(true);
        }

        else Rain.SetActive(false);
        #endregion




    }
}
