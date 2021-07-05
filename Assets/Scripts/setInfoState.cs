using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setInfoState : MonoBehaviour
{
    // Start is called before the first frame update
    public Text text_cur_state;
    public Text text_cur_temp;
    public Text text_cur_dust;

    void Start()
    {
        text_cur_state = GameObject.Find("text_cur_state").GetComponent<Text>();
        text_cur_temp = GameObject.Find("text_cur_temp").GetComponent<Text>();
        text_cur_dust = GameObject.Find("text_cur_dust").GetComponent<Text>();
        if(text_cur_state.text == "상태") Debug.Log("hi");
        Debug.Log(text_cur_state.text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
