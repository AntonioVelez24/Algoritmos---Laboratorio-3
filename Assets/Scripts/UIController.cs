using UnityEngine;
using Sirenix.OdinInspector;

public class UIController: MonoBehaviour {

    SimpleLinkedList simpleLinkedList;
    void Start()
    {
        simpleLinkedList = new SimpleLinkedList();

        simpleLinkedList.AddWindow("Ventana1");
        simpleLinkedList.AddWindow("Ventana2");
        simpleLinkedList.AddWindow("Ventana3");
        simpleLinkedList.AddWindow("Ventana4");

        simpleLinkedList.ShowAllElements();
    }
    [Button]
    public void OpenNewWindow()
    {
        simpleLinkedList.AddWindow("Nueva Ventana");
        simpleLinkedList.ShowAllElements();
    }
    [Button]
    public void CloseLastWindow()
    {
        simpleLinkedList.CloseWindow();
    }
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            CloseLastWindow();
        }
    }
}
