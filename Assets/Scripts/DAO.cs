using UnityEngine;
using System;
using System.Collections;
using MySql.Data;
using MySql.Data.MySqlClient;

public class DAO : MonoBehaviour {

	//接続パラメータ
	string SERVER    = "localhost";
	string DATABASE  = "misoten";
	string USERID    = "root";
	string PORT      = "8889";
	string PASSWORD  = "root";
	string TABLENAME = "advices";

	// Use this for initialization
	/**
	void Start () {
		StartCoroutine ( SelectData () );
	}**/
	
	public IEnumerator SelectData (String selCmd) {

		MySqlConnection con = null;

		string conCmd = 
			"server="+SERVER+";" +
			"database="+DATABASE+";" +
			"userid="+USERID+";" +
			"port="+PORT+";" +
			"password="+PASSWORD;

		try {
			con = new MySqlConnection( conCmd );
			con.Open ();
		} catch (MySqlException ex){
			Debug.Log ( ex.ToString() );
		}

		//string selCmd = "insert into modes (name) values ();";

		MySqlCommand cmd = new MySqlCommand( selCmd, con );

		IAsyncResult iAsync = cmd.BeginExecuteReader ();

		while ( !iAsync.IsCompleted ){
			yield return 0;
		}

		//実行する
		//結果が返ってくる
		MySqlDataReader rdr = 
			cmd.EndExecuteReader ( iAsync );

		//select分の場合下記の記述で取り出せる

		while ( rdr.Read() ) {
			if( !rdr.IsDBNull ( rdr.GetOrdinal ("ID") ) ){
				Debug.Log ( "ID : " + rdr.GetString ("ID") );
				Debug.Log ( "Name : " + rdr.GetString ("name") );
			}
		}


		rdr.Close ();
		rdr.Dispose ();
		con.Close ();
		con.Dispose ();


	}
}

//こんなんでつかえるでしょ
//Data dd = new Data();
//StartCoroutine (dd.SelectData());
