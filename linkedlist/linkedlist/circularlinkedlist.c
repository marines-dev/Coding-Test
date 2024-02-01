#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include "circularlinkedlist.h"

CircularList* CreateCircularList()
{
    CircularList* pReturn = NULL;
    int i = 0;
    pReturn = (CircularList*)malloc(sizeof(CircularList));
    if (pReturn != NULL)
    {
        memset(pReturn, 0, sizeof(CircularList)); //����ü�� �Ӽ����� ��� 0���� �ʱ�ȭ
    }
    else
    {
        printf("Error : �޸� �Ҵ� ����\n");
        return NULL;
    }

    return pReturn;
}

void DeleteCircularList(CircularList* _pList)
{
    int i = 0;
    if (_pList != NULL)
    {
        ClearCircularList(_pList);
        free(_pList);
    }
}

void ClearCircularList(CircularList* _pList)
{
    if (_pList != NULL)
    {
        if (_pList->currentElementCount > 0)
        {
            RemoveCLElement(_pList, 0);
        }
    }
}

int GetCircularListLength(CircularList* _pList)
{
    int ret = 0;

    if (_pList != NULL)
    {
        ret = _pList->currentElementCount;
    }

    return ret;
}

int IsCircularListEmpty(CircularList* _pList)
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

int AddCLElement(CircularList* _pList, int _index, CircularNode _element)
{
    int ret = FALSE;
    int i = 0;
    CircularNode* pPreNode = NULL;
    CircularNode* pNewNode = NULL;
    CircularNode* pLastNode = NULL;
    if (_pList != NULL)
    {
        if (_index >= 0 && _index <= _pList->currentElementCount)
        {
            pNewNode = (CircularNode*)malloc(sizeof(CircularNode));
            if (pNewNode == NULL)
            {
                printf("Error : �޸� �Ҵ� ����\n");
                return ret;
            }

            *pNewNode = _element;
            pNewNode->pLink = NULL;
            //��� ���� �ʱ�ȭ

            if (_index == 0)
            {
                if (_pList->currentElementCount == 0) // ������ �� ù ��° ��带 �߰��ϴ� ���
                {
                    _pList->pLink = pNewNode;
                    pNewNode->pLink = pNewNode;
                }
                else // ������ �ƴ� �� ù ��° ��带 �߰��ϴ� ���
                {
                    pLastNode = _pList->pLink;
                    while (pLastNode->pLink != _pList->pLink)
                    {
                        pLastNode = pLastNode->pLink;
                    }
                    
                    _pList->pLink = pNewNode;
                    pNewNode->pLink = pLastNode->pLink;
                    pLastNode->pLink = pNewNode;
                }
            }
            else //�߰��� ��带 �߰��ϴ� ���
            {
                pPreNode = _pList->pLink;
                for (i = 0; i < _index - 1; ++i)
                {
                    pPreNode = pPreNode->pLink;
                    //�߰��Ϸ��� �ε����� ���� ��带 ã�� ������ �̵��Ѵ�.
                }

                pNewNode->pLink = pPreNode->pLink;
                pPreNode->pLink = pNewNode;
            }

            _pList->currentElementCount++;
            ret = TRUE;
        }
        else
        {
            printf("Error : Index[%d] ���� �ʰ�\n", _index);
        }

        return ret;
    }
}

int RemoveCLElement(CircularList* _pList, int _index)
{
    int ret = FALSE;
    int i = 0;
    int count = 0;
    CircularNode* pPreNode = NULL;
    CircularNode* pDelNode = NULL;
    CircularNode* pLastNode = NULL;

    if (_pList != NULL)
    {
        count = GetCircularListLength(_pList);
        if (_index >= 0 && _index < count)
        {
            if (_index == 0) //������ ����̸鼭 ���ÿ� ù ��° ��带 �����ϴ� ���
            {
                pDelNode = _pList->pLink;
                if (count == 1)
                {
                    free(pDelNode);
                    _pList->pLink = NULL;
                }
                else //������ ��尡 �ƴ� ù ��° ��带 �����ϴ� ���
                {
                    pLastNode = _pList->pLink;
                    while (pLastNode->pLink != _pList->pLink) //������ ��带 ã�� ������ �̵��Ѵ�.
                    {
                        pLastNode = pLastNode->pLink;
                    }

                    pLastNode->pLink = pDelNode->pLink;
                    _pList->pLink = pDelNode->pLink;
                    free(pDelNode);
                }
            }
            else //�߰� ��带 �����ϴ� ���
            {
                pPreNode = _pList->pLink;
                for (i = 0; i < _index - 1; ++i)
                {
                    pPreNode = pPreNode->pLink;
                }

                pDelNode = pPreNode->pLink;
                pPreNode->pLink = pDelNode->pLink;
                free(pDelNode);
            }

            _pList->currentElementCount--;
            ret = TRUE;
        }
        else
        {
            printf("Error : Index[%d] ���� �ʰ�\n", _index);
        }
    }

    return ret;
}

CircularNode* GetCLElement(CircularList* _pList, int _index)
{
    int i = 0;
    CircularNode* pNode = NULL;
    if (_pList != NULL)
    {
        if (_index >= 0 && _index < _pList->currentElementCount)
        {
            pNode = _pList->pLink;
            for (i = 0; i < _index; ++i)
            {
                pNode = pNode->pLink;
            }
        }
    }

    return pNode;
}
