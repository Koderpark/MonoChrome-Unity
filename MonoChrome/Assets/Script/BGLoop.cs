using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGLoop : MonoBehaviour
{
    public GameObject level;
    private Camera mainCamera;
    private Vector2 screenBounds;

    void Start()
    {
        mainCamera = gameObject.GetComponent<Camera>();
        screenBounds = mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, mainCamera.transform.position.z));
        loadChildObject(level);
    }

    void loadChildObject(GameObject obj)
    {
        int childsNeededx = (int)Mathf.Ceil(screenBounds.x * 2 / 25.6f);
        int childsNeededy = (int)Mathf.Ceil(screenBounds.y * 2 / 16f);

        GameObject clone = Instantiate(obj) as GameObject;
        for(int i=0; i<=childsNeededx; i++) {
            GameObject c = Instantiate(clone) as GameObject;
            c.transform.SetParent(obj.transform);
            c.transform.position = new Vector3(25.6f * i, obj.transform.position.y, obj.transform.position.z);
            c.name = obj.name + i + "x";
        }
        for (int i = 0; i <= childsNeededy; i++) {
            GameObject c = Instantiate(clone) as GameObject;
            c.transform.SetParent(obj.transform);
            c.transform.position = new Vector3(obj.transform.position.x, 16f * i, obj.transform.position.z);
            c.name = obj.name + i + "y";
        }
        Destroy(clone);
        Destroy(obj.GetComponent<SpriteRenderer>());
    }

    void repositionChildObjects(GameObject obj) {
        Transform[] children = obj.GetComponentsInChildren<Transform>();
        if(children.Length > 1) {
            GameObject firstChild = children[1].gameObject;
            GameObject lastChild = children[children.Length - 1].gameObject;
            if (transform.position.x + screenBounds.x > lastChild.transform.position.x + 12.8f) {
                firstChild.transform.SetAsLastSibling();
                firstChild.transform.position = new Vector3(lastChild.transform.position.x + 25.6f, lastChild.transform.position.y, lastChild.transform.position.z);
            }
            else if(transform.position.x - screenBounds.x < firstChild.transform.position.x - 12.8f) {
                lastChild.transform.SetAsFirstSibling();
                lastChild.transform.position = new Vector3(firstChild.transform.position.x - 25.6f, firstChild.transform.position.y, firstChild.transform.position.z);
            }
            if (transform.position.y + screenBounds.y > lastChild.transform.position.y + 8f) {
                firstChild.transform.SetAsLastSibling();
                firstChild.transform.position = new Vector3(lastChild.transform.position.x, lastChild.transform.position.y + 16f, lastChild.transform.position.z);
            }
            else if (transform.position.y - screenBounds.y < firstChild.transform.position.y - 8f) {
                lastChild.transform.SetAsFirstSibling();
                lastChild.transform.position = new Vector3(firstChild.transform.position.x, firstChild.transform.position.y - 16f, firstChild.transform.position.z);
            }
        }
    }

    void LateUpdate() {
        repositionChildObjects(level);
    }
}
