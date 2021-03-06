﻿using UnityEngine;
using System.Collections;

public class RoomMaking : Photon.MonoBehaviour {

    // Use this for initialization
    void Start () {
        //	魔法の呪文
        PhotonNetwork.ConnectUsingSettings ("0.1");
    }

    // Update is called once per frame
    void Update () {
        
    }
    
    //  ランダムでルームを選び入る
    void OnJoinedLobby(){
        PhotonNetwork.JoinRandomRoom();
    }
    
    //  JoinRandomRoom()が失敗した(false)時に呼ばれる
    void OnPhotonRandomJoinFailed(){
        //  部屋に入れなかったので自分で作る
        PhotonNetwork.CreateRoom (null);
    }
    
    //  ルームに入れた時に呼ばれる（自分の作ったルームでも）
    void OnJoinedRoom(){
        //  ルームに入っている全員の画面にPlayerを生成する
        GameObject player = PhotonNetwork.Instantiate("Cube", this.transform.position, this.transform.rotation, 0);
        print(player);
        //  自分が生成したPlayerを移動可能にする
        player.GetComponent<PlayerMove>().enabled = true;
    }
    
}
