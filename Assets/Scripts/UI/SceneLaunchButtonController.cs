using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[ExecuteInEditMode]
public class SceneLaunchButtonController : MonoBehaviour {

    public string sceneName;
    public string title;
    Button buttonComp;
    Text titleComp;
	// Use this for initialization
    void OnEnable()
    {
        buttonComp = GetComponent<Button>();
        buttonComp.onClick.AddListener(HandleButtonClick);
        titleComp = GetComponentInChildren<Text>();
        titleComp.text = title;
    }
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void HandleButtonClick()
    {
        SceneManager.LoadScene(this.sceneName);
    }

    public void SetSceneName(string name){
         sceneName = name;
    }
}
