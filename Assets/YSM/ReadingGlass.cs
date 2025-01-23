using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadingGlass : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    [SerializeField] Camera cam;
    [SerializeField] RectTransform rawImage;
    [SerializeField] Canvas canvas;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Vector3 mousePos = Input.mousePosition;

            Vector3 worldPoint = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, Camera.main.nearClipPlane));

            RectTransformUtility.ScreenPointToLocalPointInRectangle(
                canvas.GetComponent<RectTransform>(),
                mousePos,
                canvas.worldCamera,
                out Vector2 localPoint
            );
            Debug.Log(localPoint);
            cam.transform.position = new Vector3(worldPoint.x, worldPoint.y, cam.transform.position.z);
            rawImage.transform.position = localPoint + new Vector2(380, 640);
            Cursor.visible = false;
            prefab.SetActive(true);
            Debug.Log("!!!!!!!!");
        }
        else
        {
            Debug.Log("?");
            Cursor.visible = true;
            prefab.SetActive(false);
        }
    }
}
