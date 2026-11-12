using Environment.Tasks;
using System.Diagnostics;
using UnityEngine;

[CreateAssetMenu(fileName = "TreeSearchTask", menuName = "Scriptable Objects/TreeSearchTask")]
public class TreeSearchTask : Task {
    public override void Execute() {
        Stopwatch stopwatch = new();
        stopwatch.Start();

        BinarySearchTree BST = new BinarySearchTree(EmployeeGovenor.instance.allEmployees[0]);
        for(int i = 1; i < EmployeeGovenor.instance.allEmployees.Length; i++) {
            BST.Insert(EmployeeGovenor.instance.allEmployees[i]);
        }
        BST.BreadthFirstSearch();

        stopwatch.Stop();
        UnityEngine.Debug.Log("stop watch timer : " + stopwatch.ElapsedMilliseconds + " ms");

    }
}
