using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Linq;

public class qualityParams : MonoBehaviour
{
    public TMP_Dropdown qualityParametrs;
    // Start is called before the first frame update
    void Start()
    {
        qualityParametrs.AddOptions(QualitySettings.names.ToList());
        
    }
}
