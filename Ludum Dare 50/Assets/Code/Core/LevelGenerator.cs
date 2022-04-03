using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject Block;
    public GameObject Walls;
    public GameObject Folder;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name != "Player") { return; }
        //Generating Walls
        GameObject NewWalls = Instantiate(Walls);
        NewWalls.transform.position = new Vector3(0, Values.BlockGenPos, 0);
        //Making a new block
        GameObject NewBlock = Instantiate(Block);
        NewBlock.transform.position = new Vector3(0, Values.BlockGenPos, 0);
        //Incrementing the block number & seting name of objects
        Values.IncrementBlockNumber();
        NewBlock.name = $"Block [{Values.BlockNumber}]";
        NewWalls.name = $"Walls [{Values.BlockNumber}]";
        //Changing the Block Position by getting the Background Size
        GameObject Background = Block.transform.Find("BG").gameObject;
        Values.ChangeBlockPos(Background.transform.localScale.y);
        //Making Floating Blocks
        GameObject FloatingBlocks = NewBlock.transform.Find("Floating Ground").gameObject;
        FloatingBlocks.SetActive(true);
        //First i set random positions of all gameobjects inside floating blocks
        foreach (Transform child in FloatingBlocks.transform)
        {
            child.position = new Vector3(Random.Range(-8f, 8f), child.position.y);
        }
        //then i just delete two of them leaving only 2 blocks
        int NumberOfFloatingBlockToDelete = 2;
        for (int i = 0; i <= NumberOfFloatingBlockToDelete; i++)
        {
            int RandomFloatingBlock = Random.Range(0, FloatingBlocks.transform.childCount);
            Destroy(FloatingBlocks.transform.GetChild(RandomFloatingBlock).gameObject);
        }
        //Now Setting everything's parent as folder
        NewBlock.transform.parent = Folder.transform;
        NewWalls.transform.parent = Folder.transform;
        //Setting Killer to ON
        GameObject PreviousBlock = GameObject.Find($"Block [{Values.BlockNumber - 1}]");
        GameObject Killer = PreviousBlock.transform.Find("KillDetect").gameObject;
        Killer.SetActive(true);

        //Destroying the detector in the end.
        Destroy(gameObject);
    }
}
