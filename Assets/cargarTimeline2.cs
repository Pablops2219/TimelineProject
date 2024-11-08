using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cargarTimeline2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public string sceneName;
    public void LoadSceneByName(string sceneName)
            {
                SceneManager.LoadScene(sceneName);
            }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
