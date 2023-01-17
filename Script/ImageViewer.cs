using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Timers;
using UnityEditor.iOS;
using UnityEngine;
using UnityEngine.UI;

public class ImageViewer : MonoBehaviour
{
	[Tooltip("디버깅 : 현재 표시되고있는 이미지 이름 저장")]
	[SerializeField]
	private string nowImgName = "팀 사진";

	public ImgLoader imgLoader;

	public Image imageObject;

	public Sprite targetSprite;



	// 모노비헤비어의 초기화
	private void Start()
	{
		//imgLoader = GetComponent<ImgLoader>();
		imgLoader = new();

		//imageObject = GetComponent<Image>();
		//targetSprite = GetComponent<Sprite>();
	}
	// 매 프레임마다 호출
	private void Update()
	{
		if(null != targetSprite)
		{
			imageObject.sprite = targetSprite;
		}

	}
	// 업데이트 종료 후 호출
	private void LateUpdate()
	{
		
	}
	// 객체 삭제시 호출
	private void OnDestroy()
	{
		
	}
	
}

public class ImgLoader
{
	public List<Sprite> sprites;
	public int idx;

	public ImgLoader()
	{
		sprites = new List<Sprite>();
		idx = -1;
	}
}

static class IMG
{
	static public class PATH
	{
		static public string BASE = "img/";
		static public string TEAMICON = BASE + "BLUECCOLI_LOGO_.png";
		static public string THUMBNAIL = BASE + "메인 썸네일.png";
	}
	static public class IDX
	{
		static public int TEAMICON = 0;
		static public int THUMBNAIL = 1;
	}
}

