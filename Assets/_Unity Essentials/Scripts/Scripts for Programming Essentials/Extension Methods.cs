using UnityEngine;

public class ExtensionMethods : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.ResetTransformation();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
public static class ExtensionMethods_
{
    public static void ResetTransformation(this Transform trans)
    {
        trans.position = Vector3.zero;
        trans.localRotation = Quaternion.identity;
        trans.localScale = new Vector3(1, 1, 1);
    }
}
