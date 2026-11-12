using UnityEngine;

namespace Environment.Tasks {
    [CreateAssetMenu(fileName = "Sorting Task", menuName = "Sorting Task")]
    public class SortingTask : Task {

        [SerializeField] public EmployeeGovenor employeeGovenor;

        public override void Execute() {
            //sorting stuff
            //Save arry somewhere
        }


        public static int binarySearch(int[] arr, int target) {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right) {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target) {
                return mid; // Target found
            } else if (arr[mid] < target) {
                left = mid + 1; // Search in the right half
            } else {
                right = mid - 1; // Search in the left half
            }
        }

        return -1; // Target not found
    }
    
    }

    
}
