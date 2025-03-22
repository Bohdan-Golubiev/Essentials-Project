using System;
using TMPro;
using UnityEngine;

public class CounterOfCollect : MonoBehaviour
{
    private TextMeshProUGUI collectibleText;
    void Start()
    {
        collectibleText = GetComponent<TextMeshProUGUI>();

        UpdateCollectibleDisplay();
    }
    void Update()
    {
        UpdateCollectibleDisplay();
    }
    private void UpdateCollectibleDisplay()
    {
        int totalCollectibles = 0;

        Type collectibleType = Type.GetType("Collectibles");

        if (collectibleType != null)
        {
            totalCollectibles += FindObjectsByType(collectibleType, FindObjectsSortMode.None).Length;
        }
        collectibleText.text = $"Collectibles remaining: {totalCollectibles}";

    }
}
