// ---------------------------------------------------------
// CharacterHp.cs
//
// 作成日:2024/03/25
// 作成者:小林慎
// ---------------------------------------------------------
using UnityEngine;
using System;
using System.Collections;

public class CharacterHp : MonoBehaviour
{
	#region 変数
	private int _hp = 0;
	#endregion

	#region プロパティ

	#endregion

	#region メソッド
	/// <summary>
	/// 初期化処理
	/// </summary>
	private void Awake()
	{
		
	}

	/// <summary>
	/// 更新前処理
	/// </summary>
	private void Start ()
	{
		
	}

	/// <summary>
	/// 更新処理
	/// </summary>
	private void Update ()
	{
		
	}

	public void Damage()
    {
		_hp--;
    }
	#endregion
}