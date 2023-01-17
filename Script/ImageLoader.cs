using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageLoader : MonoBehaviour, iSprites
{
	[Tooltip("보여줄 이미지 순서")]
	public List<Sprite> sprites;

	public int nowIdx;


	// Start is called before the first frame update
	void Start()
	{
		nowIdx = 0;
	}

	// Update is called once per frame
	void Update()
	{
		
	}

	// 다음 이미지를 보여준다.
	public Sprite Next()
	{
		if(sprites.Count == 0)
		{
			return null;
		}
		++nowIdx;
		if(sprites.Count <= nowIdx)
		{
			nowIdx = 0;
		}
		return sprites[nowIdx];
	}

	public Sprite First()
	{
		if (sprites.Count == 0)
		{
			return null;
		}
		nowIdx = 0;
		return sprites[nowIdx];
	}

	public Sprite Previous()
	{
		if (sprites.Count == 0)
		{
			return null;
		}
		if (0 < nowIdx)
			--nowIdx;
		return sprites[nowIdx];
	}

	public Sprite Move(int n)
	{
		if(0 == sprites.Count || sprites.Count <= n)
		{
			return null;
		}
		nowIdx = n;
		return sprites[nowIdx];

	}

	public int NowIdx()
	{
		return nowIdx;
	}

	public Sprite Now()
	{
		return sprites[nowIdx];
	}
}
