using UnityEngine;
public class Button : MonoBehaviour
{
    // The GameObject that will be used as the button's graphic.
    public GameObject graphic;
    // The function that will be called when the button is clicked.
    public void OnClicked()
    {
        // Do something when the button is clicked.
    }
    // Update is called once per frame.
    void Update()
    {
        // Check if the mouse is over the button.
        if (Input.GetMouseButtonDown(0) &&
            transform.position.x < Input.mousePosition.x &&
            transform.position.y < Input.mousePosition.y &&
            (transform.position.x + graphic.transform.localScale.x) > Input.mousePosition.x &&
            (transform.position.y + graphic.transform.localScale.y) > Input.mousePosition.y)
        {
            // The mouse is over the button, so call the OnClicked() function.
            OnClicked();
        }
    }
}