using UnityEngine;

namespace Utils
{
    public class SortingUtils : MonoBehaviour
    {

        








        //merge sort
        
//        static void merge(int[] inArray, int left, int middle, int right) {
//            int sizeLeft = middle - left + 1;
//            int sizeRight = right - (middle + 1);
//
//            int[] tempLeft = new int[sizeLeft];
//            int[] tempRight = new int[sizeRight];
//
//            int i = 0;
//            int j = 0;
//
//            for(i = 0; i < middle; i++) {
//                tempLeft[i] = inArray[i + left];
//            }
//
//            for(j = 0; j < middle; j++) {
//                tempRight[j] = inArray[j + right];
//            }
//
//            i = 0;
//            j = 0;
//
//            int k = left;
//            while(i < sizeLeft && j < sizeRight) {
//                if(tempLeft[i] < tempRight[j]) {
//                    inArray[k] = tempLeft[i];
//                    i++;
//                }
//                else {
//                    inArray[k] = tempRight[j];
//                    j++;
//                }
//                k++;
//            }
//
//            while(i < sizeLeft) {
//                inArray[k] = tempLeft[i];
//                i++;
//                k++;
//            }
//            while(j < sizeRight) {
//                inArray[k] = tempRight[j];
//                j++;
//                k++;
//            }
//
//
//        }
//    
//        static void mergeSort(int[] inArray, int left, int right) {
//            if (left < right) {
//                int middle = (left + right) / 2;
//                mergeSort(inArray, middle, right);
//                mergeSort(inArray, middle, left);
//            }
//        }
    }

}
