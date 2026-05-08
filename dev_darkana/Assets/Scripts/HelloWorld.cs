using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HelloWorld : MonoBehaviour
{
    [SerializeField] TMP_Text text;

    public Button enterButton;

    // This will hold a reference to the cube's material
    private Material cubeMaterial;

    private void Awake()
    {
        Debug.Log("Hello, beautiful world!");
        
        GameObject cube = GameObject.Find("Cube");
        Debug.Log("Found object: " + cube);

        if (cube != null)
        {
            cubeMaterial = cube.GetComponent<Renderer>().material;
            Debug.Log("Got material: " + cubeMaterial);
        } else {
            Debug.Log(cube + "NOT FOUND.");
        }
    }

    private void Update()
    {
        enterButton.transform.Rotate(0, 0, 0.10f);
    }

    void Start()
    {
        enterButton.onClick.AddListener(ButtonTest);
    }

    private void ButtonTest()
    {
        text.text = "This is a test";
        
        cubeMaterial.color = Color.green;
    }
}
