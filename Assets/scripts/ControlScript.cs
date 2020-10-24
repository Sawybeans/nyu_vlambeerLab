using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ControlScript : MonoBehaviour
{

    public Text text;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Press R to generate a beautiful new home";
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("mainLabScene");
        }
    }
}
