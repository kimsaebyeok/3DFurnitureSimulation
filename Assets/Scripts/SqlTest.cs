using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;     //C#의 데이터 테이블 때문에 사용
using MySql.Data;     //MYSQL함수들을 불러오기 위해서 사용
using MySql.Data.MySqlClient;    //클라이언트 기능을사용하기 위해서 사용

public class SqlTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MySqlConnection sqlconn = null;
        private string sqlDBip = "127.0.0.1";
        private string sqlDBname = "3DFurnitureSimulation";
        private string sqlDBid = "root";
        private string sqlDBpw = "88042785";
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
MySqlConnection sqlconn = null;
private string sqlDBip = "DB아이피";
private string sqlDBname = "DB네임";
private string sqlDBid = "관리자계정ID";
private string sqlDBpw = "관리자계정비번";

private void sqlConnect()
{
    //DB정보 입력
    string sqlDatabase = "Server=" + sqlDBip + ";Database=" + sqlDBname + ";UserId=" + sqlDBid + ";Password=" + sqlDBpw + "";

    //접속 확인하기
    try
    {
        sqlconn = new MySqlConnection(sqlDatabase);
        sqlconn.Open();
        Debug.Log("SQL의 접속 상태 : " + sqlconn.State); //접속이 되면 OPEN이라고 나타남
    }
    catch (Exception msg)
    {
        Debug.Log(msg); //기타다른오류가 나타나면 오류에 대한 내용이 나타남
    }
}

private void sqldisConnect()
{
    sqlconn.Close();
    Debug.Log("SQL의 접속 상태 : " + sqlconn.State); //접속이 끊기면 Close가 나타남 
}


출처: https://yourpresence.tistory.com/87 [너란존재]