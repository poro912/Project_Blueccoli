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
		// ���� ��ü���� �̹����� �̹����δ� ������Ʈ ������ �����´�.
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
		// 2�ʰ� ������
		if (timer > interval)
		{
			// ���� �̹����� �ҷ��� ����
			image.sprite = sprites.Next();
			// Ÿ�̸� �ʱ�ȭ
			timer = 0.0f;
		}
	}
}
