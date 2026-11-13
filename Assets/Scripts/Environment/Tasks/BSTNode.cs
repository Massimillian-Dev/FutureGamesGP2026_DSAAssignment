using Environment;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utils;

public class BSTNode<T> {
    private Employee data;
    public BSTNode<T>? leftChild = null;
    public BSTNode<T>? rightChild = null;

    public Employee GetData() {
        return data;
    }

    public BSTNode(Employee inData) {
        data = inData;
    }
}

public class BinarySearchTree {
    public BSTNode<Employee> root;

    public BinarySearchTree(Employee rootData) {
        root = new BSTNode<Employee>(rootData);
    }

    public void Insert(Environment.Employee inData) {
        BSTNode<Employee> newNode = new BSTNode<Employee>(inData);
        BSTNode<Employee>? currentNode = root;
        BSTNode<Employee> lastParent = root;
        while(currentNode != null) {

            if(DateTime.ParseExact(inData.lastEntranceInEngineRoom, "yyyy-MM-ddTHH:mm:ss", System.Globalization.CultureInfo.InvariantCulture)
            < DateTime.ParseExact(currentNode.GetData().lastEntranceInEngineRoom, "yyyy-MM-ddTHH:mm:ss", System.Globalization.CultureInfo.InvariantCulture))
            {
                lastParent = currentNode;
                currentNode = currentNode.leftChild;
            }
            else {
                lastParent = currentNode;
                currentNode = currentNode.rightChild;
            }
        }

        if(DateTime.ParseExact(inData.lastEntranceInEngineRoom, "yyyy-MM-ddTHH:mm:ss", System.Globalization.CultureInfo.InvariantCulture)
        < DateTime.ParseExact(lastParent.GetData().lastEntranceInEngineRoom, "yyyy-MM-ddTHH:mm:ss", System.Globalization.CultureInfo.InvariantCulture)) {

            lastParent.leftChild = newNode;
        }
        else {

            lastParent.rightChild = newNode;
        }

    }

    public void BreadthFirstSearch() {
        Queue<BSTNode<Employee>> que = new Queue<BSTNode<Employee>>();
        que.Enqueue(root);

        while(que.Count > 0) {

            BSTNode<Employee> node = que.Dequeue();

            Debug.Log("You Breadth First Searched " + node.GetData().lastEntranceInEngineRoom);

            if(node.leftChild != null ) {
                que.Enqueue(node.leftChild);
            }

            if(node.rightChild != null) {
                que.Enqueue(node.rightChild);
            }
        }

    }

}


