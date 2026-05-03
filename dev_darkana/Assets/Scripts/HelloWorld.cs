using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HelloWorld : MonoBehaviour
{
    [SerializeField]
    TMP_Text text;
    [SerializeField]
    public Button enterButton;
    
    void Start()
    {
        Debug.Log("Hello, beautiful world!");
        
        enterButton.onClick.AddListener(ButtonTest);
    }

    private void ButtonTest()
    {
        text.text = "This is a test";
    }
}
