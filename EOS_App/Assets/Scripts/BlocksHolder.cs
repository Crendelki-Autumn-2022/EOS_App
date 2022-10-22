using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BlocksHolder : MonoBehaviour
{
    private List<Block> blocks = new List<Block>();

    private void Start()
    {
        CheckForBlocks();
    }

    public void CheckForBlocks()
    {
        blocks = FindObjectsOfType<Block>().ToList();
    }
}
