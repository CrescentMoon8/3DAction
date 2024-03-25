// ---------------------------------------------------------
// Gravity.cs
//
// 作成日:2024/03/25
// 作成者:小林慎
// ---------------------------------------------------------
using UnityEngine;
using System;
using System.Collections;

public class Gravity : MonoBehaviour
{
	#region 変数
	private bool _isHit = default;
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
	private void Update()
	{
		RaycastHit hit;

		Vector3 scale = transform.lossyScale / 4;
		scale.y /= 2;

		_isHit = Physics.BoxCast(transform.position, scale, Vector3.down, out hit, transform.rotation, 0.1f);

		/*if (_isHit)
		{
			return;
		}
		else
		{
			transform.Translate(Vector3.down * 0.1f);
		}*/
	}

	/// <summary>
	/// 物理処理
	/// </summary>
	private void FixedUpdate()
	{
		if (_isHit)
		{
			return;
		}
		else
		{
			transform.Translate(Vector3.down * 0.1f);
		}
	}

	void OnDrawGizmos()
	{
		RaycastHit hit;

		var scale = transform.lossyScale / 4;
		scale.y /= 2;

		var isHit = Physics.BoxCast(transform.position, scale, Vector3.down, out hit, transform.rotation, 0.01f);
		if (isHit)
		{
			Gizmos.DrawRay(transform.position, Vector3.down * hit.distance);
			Gizmos.DrawWireCube(transform.position + Vector3.down * hit.distance, scale * 2);
		}
		else
		{
			Gizmos.DrawRay(transform.position, Vector3.down * 100);
		}
	}
	#endregion
}