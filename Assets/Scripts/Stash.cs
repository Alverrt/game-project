using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stash : MonoBehaviour
{

    public Transform stashParent;
    public List<Stashable> CollectedObjects = new List<Stashable>();
    public int CollectedCount => CollectedObjects.Count;
    public float collectionHeight = 1;
    public int maxCollectableCount = 5;
    public Text collectableNumber;
    public int collectableNo = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void AddStash(collectable collectedObject)
    {
        if (CollectedCount >= maxCollectableCount)
            return;

        var yLocalPosition = CollectedCount * collectionHeight;

        var stashable = collectedObject.Collect();
        stashable.CollectStashable(stashParent, yLocalPosition, CompleteCollection);
        CollectedObjects.Add(stashable);
        
        collectableNo++;
        collectableNumber.text = collectableNo.ToString();
    }

    private void CompleteCollection()
    {


    }

    public Stashable RemoveStash()
    {
        if (CollectedCount <= 0)
            return null;

        var stashable = CollectedObjects[CollectedCount - 1];

        CollectedObjects.Remove(stashable);
        stashable.transform.parent = null;

        collectableNo--;
        collectableNumber.text = collectableNo.ToString();

        return stashable;



    }
}
