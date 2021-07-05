using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System.IO;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
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
        // paths.Add(@"C:\Users\nier8\AppData\Local\Programs\Python\Python37\Lib");
        // paths.Add(@"C:\Users\nier8\AppData\Local\Programs\Python\Python37\Lib\site-packages");
        engine.SetSearchPaths (paths);

		var source = engine.CreateScriptSourceFromString(script);
		source.Execute(scope);

        // engine.ImportModule("ctypes");
		Debug.Log(scope.GetVariable<string>("cur_temp"));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
