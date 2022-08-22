using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneOnClick : MonoBehaviour
{

    int puntaje = PlayerPrefs.GetInt("puntaje");
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log(gameObject.name);
        PlayerPrefs.SetString("nombre", gameObject.name);
        PlayerPrefs.SetInt("puntaje", puntaje + 1);
        SceneManager.LoadScene("Escena final");
    }
}
