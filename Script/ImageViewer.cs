using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Timers;
using UnityEditor.iOS;
using UnityEngine;
using UnityEngine.UI;

public class ImageViewer : MonoBehaviour
{
	[Tooltip("����� : ���� ǥ�õǰ��ִ� �̹��� �̸� ����")]
	[SerializeField]
	private string nowImgName = "�� ����";

	public ImgLoader imgLoader;

	public Image imageObject;

	public Sprite targetSprite;



	// ���������� �ʱ�ȭ
	private void Start()
	{
		//imgLoader = GetComponent<ImgLoader>();
		imgLoader = new();

		//imageObject = GetComponent<Image>();
		//targetSprite = GetComponent<Sprite>();
	}
	// �� �����Ӹ��� ȣ��
	private void Update()
	{
		if(null != targetSprite)
		{
			imageObject.sprite = targetSprite;
		}

	}
	// ������Ʈ ���� �� ȣ��
	private void LateUpdate()
	{
		
	}
	// ��ü ������ ȣ��
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
		static public string THUMBNAIL = BASE + "���� �����.png";
	}
	static public class IDX
	{
		static public int TEAMICON = 0;
		static public int THUMBNAIL = 1;
	}
}

