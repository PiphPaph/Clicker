using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class auto_5 : MonoBehaviour
{
    public static float count_click = 2.5f; // счетчик кликов на кнопку
    public static double incomePerClick = 0;
    private float count_grade = 20f; // стоимость грейда
    public Text text;
    
    public void ButtonClick_5()
    {   
        if (score_value.count>=count_grade) //проверка стоимости и кол-ва очков для грейда
        {
            score_value.count-=count_grade; // списывание очков
            count_grade+=10f; // увеличение стоимости грейда
            score_value.buttonValue+=count_click; //увеличение очков на величину равную кол-ву нажатию на кнопку
            incomePerClick += 2.5;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        text.text = "Upgrade price " + count_grade.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Upgrade price " + count_grade.ToString();
    }
}
