using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImagePlayer : MonoBehaviour
{
	public Image image;
	public ImageLoader loader;
	public float timer;
	public float interval;

	public iSprites sprites;

	// Start is called before the first frame update
	void Start()
	{
		// 현재 객체에서 이미지와 이미지로더 컴포넌트 정보를 가져온다.
		image	= GetComponent<Image>();
		//loader	= GetComponent<ImageLoader>();
		timer	= 0.0f;
		if(interval <= 0.0f)
		{
			interval = 2.0f;
		}
		// image.sprite = loader.First();
		// sprites = loader;
		sprites = loader;
		image.sprite = sprites.First();

		//image.sprite = loader.sprites[0];
	}

	// Update is called once per frame
	void Update()
	{
		timer += Time.deltaTime;
		// 2초가 지나면
		if (timer > interval)
		{
			// 다음 이미지를 불러와 적용
			image.sprite = sprites.Next();
			// 타이머 초기화
			timer = 0.0f;
		}
	}
}
