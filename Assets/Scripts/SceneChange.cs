using UnityEngine;
using UnityEngine.InputSystem;

public class FiveClick : MonoBehaviour
{
    public InputActionReference clickAction;
    private int clickCount = 0;
    public GameObject targetObject; // Объект, с которым будет взаимодействовать скрипт


    void OnEnable()
    {
        clickAction.action.Enable();
        clickAction.action.performed += OnClick;
    }

    void OnDisable()
    {
        clickAction.action.performed -= OnClick;
        clickAction.action.Disable();
    }

    void OnClick(InputAction.CallbackContext context)
    {
        clickCount++;
        if (clickCount == 5)
        {
            // Действие, которое нужно выполнить при пятикратном нажатии
            Debug.Log("Пять нажатий!");
            // Замените этот код на то, что нужно сделать при пятикратном нажатии
            if (targetObject != null)
            {
                targetObject.SetActive(!targetObject.activeSelf);
            }

            clickCount = 0; // Сброс счетчика
        }
    }
}