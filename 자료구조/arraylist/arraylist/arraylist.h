#pragma once
#ifndef _ARRAYLIST_
#define _ARRAYLIST_

typedef struct
{
	int data;
} ArrayListNode;

typedef struct
{
	int maxElementCount;
	int currentElementCount;
	ArrayListNode* pElement;
} ArrayList;

ArrayList* CreateArrayList(int _maxElementCount); //����Ʈ ����
void DeleteArrayList(ArrayList* _pList); //����Ʈ ����
int AddElement(ArrayList* _pList, int _position, ArrayListNode _element); //���� �߰�
int RemoveElement(ArrayList* _pList, int _position); //���� ����
int IsArrayListFull(ArrayList* _pList); //���� �߰� ���� ���� �˻�
ArrayListNode* GetElement(ArrayList* _pList, int _position); //���� ��ȯ
void ClearArrayList(ArrayList* _pList); // ����Ʈ �ʱ�ȭ
int GetArrayListLength(ArrayList* _pList); //���ҹ�ȯ

#endif

#ifndef _COMMON_LIST_DEF_
#define _COMMON_LIST_DEF_

#define TRUE 1
#define FALSE 0

#endif