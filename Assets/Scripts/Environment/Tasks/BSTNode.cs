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
        //assuming that values are unique
        BSTNode<Employee> newNode = new BSTNode<Employee>(inData);
        BSTNode<Employee>? currentNode = root;
        BSTNode<Employee> lastParent = root;
        while(currentNode != null) { // Keep searching until we find an empty child slot



            if(DateTime.ParseExact(inData.lastEntranceInEngineRoom, "yyyy-MM-ddTHH:mm:ss", System.Globalization.CultureInfo.InvariantCulture)
            < DateTime.ParseExact(currentNode.GetData().lastEntranceInEngineRoom, "yyyy-MM-ddTHH:mm:ss", System.Globalization.CultureInfo.InvariantCulture)) /*node we are examining*/
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

            //BSTNode<Employee> currentNode = new BSTNode<Employee>(root.GetData());
        

        while(que.Count > 0) {

            BSTNode<Employee> node = que.Dequeue();

            Debug.Log(node.GetData().lastEntranceInEngineRoom);

            if(node.leftChild != null ) {
                que.Enqueue(node.leftChild);
            }

            if(node.rightChild != null) {
                que.Enqueue(node.rightChild);
            }
        }

    }

}


