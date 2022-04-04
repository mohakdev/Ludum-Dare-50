using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject Block;
    public GameObject Walls;
    public GameObject Folder;
    bool AlreadyRan = false;
    /*
    Whoever is reading this consider this a warning!!!
    If you read the code below you may suffer from a headache or worse
    I know the code works and i tried adding comments to explain what does what but it still
    looks like spaghetti code.
    */
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name != "Player") { return; }
        if (AlreadyRan) { return; }
        //Generating Walls
        GameObject NewWalls = Instantiate(Walls);
        NewWalls.transform.position = new Vector3(0, Values.BlockGenPos, 0);
        //Making a new block
        GameObject NewBlock = Instantiate(Block);
        NewBlock.transform.position = new Vector3(0, Values.BlockGenPos, 0);
        //Incrementing the block number & spaghetti name of objects
        Values.IncrementBlockNumber();
        NewBlock.name = $"Block [{Values.BlockNumber}]";
        NewWalls.name = $"Walls [{Values.BlockNumber}]";
        //Changing the Block Position by getting the Background Size
        GameObject Background = Block.transform.Find("BG").gameObject;
        Values.ChangeBlockPos(Background.transform.localScale.y);
        //Making Floating Blocks
        GameObject FloatingBlocks = NewBlock.transform.Find("Floating Ground").gameObject;
        //First I set random positions of all Game Objects inside floating blocks
        foreach (Transform child in FloatingBlocks.transform)
        {
            child.position = new Vector3(Random.Range(-8f, 8f), child.position.y);
        }
        //Adding coins
        GameObject Coins = NewBlock.transform.Find("Coins").gameObject;
        foreach (Transform child in Coins.transform)
        {
            child.position = new Vector3(Random.Range(-10f, 10f), child.position.y);
        }
        //Now Setting everything's parent as folder
        NewBlock.transform.parent = Folder.transform;
        NewWalls.transform.parent = Folder.transform;
        AlreadyRan = true;
    }
}
