#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include "singlylinkedlist.h"

SinglyList* CreateSinglyList()
{
    SinglyList* pReturn = NULL;
    int i = 0;
    pReturn = (SinglyList*)malloc(sizeof(SinglyList));
    if (pReturn != NULL)
    {
        memset(pReturn, 0, sizeof(SinglyList)); //����ü�� �Ӽ����� ��� 0���� �ʱ�ȭ
    }
    else
    {
        printf("Error : �޸� �Ҵ� ����\n");
        return NULL;
    }

    return pReturn;
}

void DeleteSinglyList(SinglyList* _pList)
{
    if (_pList != NULL)
    {
        ClearSinglyList(_pList);
        free(_pList);
    }
}

void ClearSinglyList(SinglyList* _pList)
{
    if (_pList != NULL)
    {
        if (_pList->currentElementCount > 0)
        {
            RemoveSLElement(_pList, 0);
        }
    }
}

int GetSinglyListLength(SinglyList* _pList)
{
    int ret = 0;

    if (_pList != NULL)
    {
        ret = _pList->currentElementCount;
    }

    return ret;
}

int IsSinglyListEmpty(SinglyList* _pList)
{
    int ret = FALSE;
    if (_pList != NULL)
    {
        if (_pList->currentElementCount == 0)
        {
            ret = TRUE;
        }
    }

    return ret;
}

int AddSLElement(SinglyList* _pList, int _index, SinglyNode _element)
{
    int ret = FALSE;
    int i = 0;
    SinglyNode* pPreNode = NULL;
    SinglyNode* pNewNode = NULL;
    if (_pList != NULL)
    {
        if (_index >= 0 && _index <= _pList->currentElementCount)
        {
            pNewNode = (SinglyNode*)malloc(sizeof(SinglyNode));
            if (pNewNode != NULL)
            {
                *pNewNode = _element; //��� �� ����
                pNewNode->pLink = NULL; //��ũ �ʱ�ȭ

                pPreNode = &(_pList->headerNode);
                for (i = 0; i < _index; ++i)
                {
                    pPreNode = pPreNode->pLink; //��尡 �߰��� ��ġ�� �̵�
                }

                pNewNode->pLink = pPreNode->pLink;
                pPreNode->pLink = pNewNode; 
                //�߰��� ���� ���� ��� ������ ��ũ �缳��

                _pList->currentElementCount++;
                ret = TRUE;
            }
            else
            {
                printf("Error : �޸� �Ҵ� ����\n");
                return ret;
            }
        }
        else
        {
            printf("Error : Index[%d] ���� �ʰ�\n", _index);
        }

        return ret;
    }
    return 0;
}

int RemoveSLElement(SinglyList* _pList, int _index)
{
    int ret = FALSE;
    int i = 0;
    int count = 0;
    SinglyNode* pNode = NULL;
    SinglyNode* pDelNode = NULL;
    if (_pList != NULL)
    {
        count = GetSinglyListLength(_pList);
        if (_index >= 0 && _index < count)
        {
            pNode = &(_pList->headerNode);
            for (i = 0; i < _index; ++i)
            {
                pNode = pNode->pLink;
                //������ ��� ��ġ�� �̵�
            }

            pDelNode = pNode->pLink;
            pNode->pLink = pDelNode->pLink;
            //������ ���� ���� ��� ������ ��ũ �缳��
            free(pDelNode); //������ ��� �޸� ����
            _pList->currentElementCount--;
            ret = TRUE;
        }
        else
        {
            printf("Error : Index[%d] ���� �ʰ�\n", _index);
        }

        return ret;
    }
}

SinglyNode* GetSLElement(SinglyList* _pList, int _index)
{
    SinglyNode* pReturn = NULL;
    int i = 0;
    SinglyNode* pNode = NULL;
    if (_pList != NULL)
    {
        if (_index >= 0 && _index < _pList->currentElementCount)
        {
            pNode = &(_pList->headerNode);
            for (i = 0; i <= _index; ++i)
            {
                pNode = pNode->pLink;
            }

            pReturn = pNode;
        }
    }

    return pReturn;
}
