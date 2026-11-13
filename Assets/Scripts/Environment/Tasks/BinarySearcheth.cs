using System;
using System.Globalization;
using System.IO.Enumeration;
using UnityEngine;

namespace Environment.Tasks {
    [CreateAssetMenu(fileName = "BinarySearcheth", menuName = "Scriptable Objects/BinarySearcheth")]

    public class BinarySearcheth : Task {

        public static int BinarySearch(Employee[] array, DateTime target) {
            int lefty = 0;
            int righty = array.Length - 1;

            while(lefty <= righty) {

                int mid = (lefty + righty) / 2;

                if(DateTime.ParseExact(array[mid].lastEntranceInEngineRoom, "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture) == target) {
                    return mid;
                }
                if(DateTime.ParseExact(array[mid].lastEntranceInEngineRoom, "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture) < target) {
                    lefty = mid + 1;
                }
                else {
                    righty = mid - 1;
                }
            }
            return -1;
        }


        public override void Execute() {
            //   Main(WorkerSingleT.Instance.Workers);
            int low = BinarySearch(EmployeeGovenor.instance.allEmployees, new DateTime(1970, 01, 01, 00, 00, 00));
            int high = BinarySearch(EmployeeGovenor.instance.allEmployees, new DateTime(2234, 08, 07, 20, 44, 44));
            for(int i = low; i <= high; i++) {
                Debug.Log("You Binary Serched for " + EmployeeGovenor.instance.allEmployees[i].name + EmployeeGovenor.instance.allEmployees[i].lastEntranceInEngineRoom);
            }
            Debug.Log(low);
            Debug.Log(high);
        }



    }
}

