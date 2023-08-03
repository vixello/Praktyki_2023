using UnityEngine;

public class CopyPasteGameObjects : MonoBehaviour
{
    public GameObject gameObjectToCopy;
    public int numberOfCopies = 100;

    void Start()
    {
        CopyAndPaste();
    }

    void CopyAndPaste()
    {
        for (int i = 0; i < numberOfCopies; i++)
        {
            GameObject newGameObject = Instantiate(gameObjectToCopy);
            Vector3 newPosition = new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f), Random.Range(-10f, 10f));
            newGameObject.transform.position = newPosition;
        }
    }
}
