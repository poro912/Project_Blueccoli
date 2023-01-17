using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public interface iSprites
{
    // 가장 처음 이미지로 변경
    public Sprite First();
    // 다음 이미지로 변경
    public Sprite Next();
    // 이전 이미지로 변경
    public Sprite Previous();
    // N번 이미지로 변경
    public Sprite Move(int n);
    // 현재 인덱스 반환
    public int NowIdx();
    public Sprite Now();

}
