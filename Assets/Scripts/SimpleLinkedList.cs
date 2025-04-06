using UnityEngine;

public class Window
{
    #region Private
    private string name;
    private Window next = null;
    #endregion
    #region Getters
    public string Name => name;
    public Window Next => next;
    #endregion
    #region Setter
    public Window(string _name)
    {
        name = _name;
    }
    public void SetNext(Window _next)
    {
        next = _next;
    }
    #endregion
}

public class SimpleLinkedList
{
    public Window lastNode;
    public Window head;
    public int count;
    public virtual void AddWindow(string newValue)
    {
        Window newNode = new Window(newValue);

        if (head == null)
        {
            lastNode = newNode;
            head = newNode;
        }
        else
        {
            lastNode.SetNext(newNode);
            lastNode = newNode;
        }           
        count++;
    }
    public void CloseWindow()
    {
        if (head != null)
        {
            string closedWindowName = head.Name;
            head = head.Next;

            if (head == null)
            {
                lastNode = null; 
            }

            int remainingWindows = CountWindows();
            Debug.Log("Se cerró la ventana " + closedWindowName + ". Quedan " + remainingWindows + " ventana(s) abierta(s).");
        }
        else
        {
            Debug.Log("No hay ventanas abiertas.");
        }
    }
    private int CountWindows()
    {
        int count = 0;
        Window temp = head;
        while (temp != null)
        {
            count++;
            temp = temp.Next;
        }
        return count;
    }
    public virtual void ShowAllElements(Window element = null, int _count = 0)
    {
        if (element == null)
        {
            element = head;
        }
        if (_count == count)
        {
            Debug.Log("Se recorrio toda la lista");
            return;
        }
        Debug.Log("Nombre de la Ventana:" + element.Name);

        ShowAllElements(element.Next, _count + 1);
    }
}