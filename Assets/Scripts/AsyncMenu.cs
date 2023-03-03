using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class AsyncMenu : MonoBehaviour {

    public Button? connectBtn;
    public TMP_Dropdown? dropdown;

    private List<string> options = new();

    void OnEnable() {
        options.Add("BasicExample");
        options.Add("MovingBlock");

        dropdown.AddOptions(options);

        connectBtn.onClick.AddListener(onButtonClick);
    }

    void onButtonClick() {
        var sceneName = options[dropdown.value];
        Debug.Log("Loading scene " + sceneName);
        SceneManager.LoadScene(sceneName);
        
        var millisecondTime = Time.fixedDeltaTime * 1000;

        Debug.Log("Loading with time(ms): " + millisecondTime);

        Ecsact.Defaults.Runtime.async.Connect("good?delta_time="+millisecondTime);
    }
}
