using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public interface iSprites
{
    // ���� ó�� �̹����� ����
    public Sprite First();
    // ���� �̹����� ����
    public Sprite Next();
    // ���� �̹����� ����
    public Sprite Previous();
    // N�� �̹����� ����
    public Sprite Move(int n);
    // ���� �ε��� ��ȯ
    public int NowIdx();
    public Sprite Now();

}
