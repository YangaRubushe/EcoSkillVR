using UnityEngine;
using UnityEngine.UI;

public class TestButtonPress : MonoBehaviour
{
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(() => Debug.Log("Button Pressed"));
    }
}
