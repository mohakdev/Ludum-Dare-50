using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject Block;
    public GameObject FloatingBlocks;
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
        //Making Background
        GameObject Background = Block.transform.Find("BG").gameObject;
        Values.ChangeBlockPos(Background.transform.localScale.y);
        //Now Setting everything's parent as folder
        NewBlock.transform.parent = Folder.transform;
        NewWalls.transform.parent = Folder.transform;
        //Setting Killer to ON
        GameObject CurrentBlock = GameObject.Find($"Block [{Values.BlockNumber - 1}]");
        print($"Block [{Values.BlockNumber - 2}]");
        GameObject Killer = CurrentBlock.transform.Find("KillDetect").gameObject;
        Killer.SetActive(true);
        //This is just to conserve some memory and make the game lighter
        GameObject PreviousBlock = GameObject.Find($"Block [{Values.BlockNumber - 2}]");
        GameObject PreviousWall = GameObject.Find($"Walls [{Values.BlockNumber - 2}]");
        Destroy(PreviousBlock);
        Destroy(PreviousWall);
        //Destroying the detector in the end.
        Destroy(gameObject);
    }
}
