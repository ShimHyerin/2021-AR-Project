using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System.IO;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

public class cur_temp : MonoBehaviour
{
    // Start is called before the first frame update
    public Text text_cur_temp;
    public Text text_cur_dust;
    public Text text_cur_state;
    public GameObject mobile_sunny;
    public GameObject mobile_rain;
    public GameObject mobile_cloudy;
    public Button dustBtn;
    public GameObject dust_bad;

    void Start()
    {
        string script;
        string moderaterfile = Application.dataPath + "/Scripts/test.py";

        using (StreamReader sr = new StreamReader(moderaterfile, System.Text.Encoding.UTF8))
        {
            script = sr.ReadToEnd();
        }

        var engine = Python.CreateEngine();
		var scope = engine.CreateScope();

        var paths = engine.GetSearchPaths();
        paths.Add(Application.dataPath + "/Python/Lib");
        paths.Add(Application.dataPath + "/Python27/Lib");
        paths.Add(@"C:\Python27\Lib");
        paths.Add(@"C:\Python27\Lib\site-packages");
        engine.SetSearchPaths (paths);

		var source = engine.CreateScriptSourceFromString(script);
		source.Execute(scope);
        // Debug.Log(scope.GetVariable<string>("cur_temp"));
        Debug.Log(scope.GetVariable<string>("state"));
        // Debug.Log(scope.GetVariable<string>("test"));
        // fine-dust if state
        

        text_cur_temp = GameObject.Find("text_cur_temp").GetComponent<Text>();
        text_cur_temp.text = scope.GetVariable<string>("cur_temp");
        text_cur_dust = GameObject.Find("text_cur_dust").GetComponent<Text>();
        if(scope.GetVariable<string>("dust") == "\\xeb\\xb3\\xb4\\xed\\x86\\xb5"){
            text_cur_dust.text = "보통";
        }
        else if(scope.GetVariable<string>("dust") == "\\xec\\xa2\\x8b\\xec\\x9d\\x8c"){
            text_cur_dust.text = "좋음";
        }
        else{
            text_cur_dust.text = "나쁨";
        }

        text_cur_state = GameObject.Find("text_cur_state").GetComponent<Text>();
        if(scope.GetVariable<string>("state") == "\\xed\\x9d\\x90\\xeb\\xa6\\xbc"){
            text_cur_state.text = "흐림";
            mobile_cloudy.SetActive(true);
            mobile_rain.SetActive(false);
            mobile_sunny.SetActive(false);
        }
        else if(scope.GetVariable<string>("state") == "\\xea\\xb5\\xac\\xeb\\xa6\\x84\\xeb\\xa7\\x8e\\xec\\x9d\\x8c"){
            text_cur_state.text = "구름많음";
            mobile_cloudy.SetActive(true);
            mobile_rain.SetActive(false);
            mobile_sunny.SetActive(false);
        }
        else if(scope.GetVariable<string>("state") == "\\xeb\\xb9\\x84"){
            text_cur_state.text = "비";
            mobile_rain.SetActive(true);
            mobile_cloudy.SetActive(false);
            mobile_sunny.SetActive(false);
        }
        else if(scope.GetVariable<string>("state") == "\\xeb\\xa7\\x91\\xec\\x9d\\x8c"){
            text_cur_state.text = "맑음";
            mobile_rain.SetActive(false);
            mobile_cloudy.SetActive(false);
            mobile_sunny.SetActive(true);
        }
        else{
            text_cur_state.text = "맑음";
            mobile_rain.SetActive(false);
            mobile_cloudy.SetActive(false);
            mobile_sunny.SetActive(true);
        }
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
