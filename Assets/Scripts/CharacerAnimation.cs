// ---------------------------------------------------------
// CharacerAnimation.cs
//
// 作成日:2024/03/25
// 作成者:小林慎
// ---------------------------------------------------------
using UnityEngine;
using System;
using System.Collections;

public class CharacerAnimation : MonoBehaviour
{
	#region 変数
	private Animator _characterAnimator = default;

	private const string ATTACK_ANIMATION = "attack_shift";
	#endregion

	#region プロパティ

	#endregion

	#region メソッド
	/// <summary>
	/// 初期化処理
	/// </summary>
	private void Awake()
	{
		_characterAnimator = GetComponent<Animator>();
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

	public void AttackAnimation()
    {
		_characterAnimator.CrossFade(ATTACK_ANIMATION, 0.1f, 0, 0);
    }
	#endregion
}