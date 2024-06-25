using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class score_value : MonoBehaviour
{
    //переменная для счетчика
    public static double count;
    public static double buttonValue;
    // текстовая переменная для отображения счетчика в текстовом поле
    public Text text;
    public Text incomePerSecond;
    private double income;
    private double numberAfterPoint;
    private double wholePart;
    private double oldWholePart;
    private double time = 0f;
    private double updateTime = 0.1f;
    
    // Start is called before the first frame update
    private void calculate()
    {
        oldWholePart = wholePart;
        count+=buttonValue / 10;
        wholePart = (Math.Truncate(count)); // берём только целую часть
        updateTime = 0.1 / (wholePart - oldWholePart);
        
    }
    void Start()
    {
        count = 0f;
        // перевод числа в текст для вывода
        text.text = oldWholePart.ToString();
        income = auto_1.incomePerClick + auto_5.incomePerClick;
        incomePerSecond.text = "Income per second " +  income.ToString();
        InvokeRepeating("calculate", 0.001f, 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        time+=Time.deltaTime;
        if (time >= updateTime)
        {
            time = 0f;
            if (wholePart - oldWholePart >= 1)
            {
                oldWholePart++;
            }
            text.text = oldWholePart.ToString();
            
        }
        income = auto_1.incomePerClick + auto_5.incomePerClick;
        incomePerSecond.text = "Income per second " +  income.ToString();
        
    }
}
