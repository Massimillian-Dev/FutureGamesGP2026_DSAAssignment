using System;
using System.Collections.Concurrent;
using UnityEngine;

namespace Environment.Tasks {
    [CreateAssetMenu(fileName = "QuickSort", menuName = "Scriptable Objects/QuickSort")]
    public class QuickSortah : Task {
        public override void Execute() {
            QuickSort(EmployeeGovenor.instance.allEmployees, 0, EmployeeGovenor.instance.allEmployees.Length - 1);
        }


        public static void QuickSort(Employee[] inArray, int first, int last) {
            if(first < last) {
                int pivotIndex = Partition(inArray, first, last);
                QuickSort(inArray, first, pivotIndex - 1);
                QuickSort(inArray, pivotIndex + 1, last);
            }
        }


        public static int Partition(Employee[] inArray, int first, int last) {
            int ranIndex = UnityEngine.Random.Range(first, last);
            DateTime pivot = DateTime.Parse(inArray[ranIndex].lastEntranceInEngineRoom);

            Employee randomArray = inArray[ranIndex];
            inArray[ranIndex] = inArray[ranIndex];
            inArray[last] = randomArray;

            int i = first - 1;

            for(int j = first; j < last - 1; j++) {
                if(DateTime.ParseExact(inArray[j].lastEntranceInEngineRoom, "yyyy-MM-ddTHH:mm:ss", System.Globalization.CultureInfo.InvariantCulture) < pivot) {
                    i = i + 1;

                    Employee tempArray = inArray[j];
                    inArray[j] = inArray[i];
                    inArray[i] = tempArray;
                }
                else {
                    Employee tempArray = inArray[last];
                    inArray[last] = inArray[i + 1];
                    inArray[i + 1] = tempArray;
                }
            }
            return i + 1;

        }
    }
}


