using System;
using System.Collections.Generic;
using System.Text;

namespace DZ2
{
    public interface ILinkedList
    {
        int GetCount(); // Возвращает количество элементов в списке 
        void AddNode(int value); // Добовляет новый элемент списка 
        void AddNodeAfter(Node node, int value); // Добовляет новый элемент после определенного элемента 
        void RemoveNode(int index); // Удаляет элемент по порядковому номеру 
        void RemoveNode(Node node); // Удаляет указанный элемент
        Node FindNode(int searchValue); //ищет элемент по его значению
    }
}
