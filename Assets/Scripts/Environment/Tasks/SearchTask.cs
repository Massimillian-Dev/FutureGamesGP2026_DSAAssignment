using System;
using UnityEngine;

[CreateAssetMenu(fileName = "SearchTask", menuName = "Scriptable Objects/SearchTask")]
public class SearchTask : ScriptableObject
{
    private BinarySearch(EmployeeGovenor.instance.allEmployees, DateTime.ParseExact("2024-06-01T12:00:00", "yyyy-MM-ddTHH:mm:ss", System.Globalization.CultureInfo.InvariantCulture));

    private void BinarySearch(DateTime[] inArray, DateTime elementToSearch)
    {
        int bottomIndexOfSubarray = 0;
        int topIndexOfSubarray = inArray.Length - 1;

        while (bottomIndexOfSubarray <= topIndexOfSubarray)
        {
            int middleIndex = bottomIndexOfSubarray + (topIndexOfSubarray - bottomIndexOfSubarray) / 2;

            if (inArray[middleIndex] == DateTime.ParseExact(elementToSearch.ToString("yyyy-MM-ddTHH:mm:ss"), "yyyy-MM-ddTHH:mm:ss", System.Globalization.CultureInfo.InvariantCulture))
            {
                Debug.Log($"Element {elementToSearch} found at index {middleIndex}.");
                return;
            }

            if (inArray[middleIndex] < DateTime.ParseExact(elementToSearch.ToString("yyyy-MM-ddTHH:mm:ss"), "yyyy-MM-ddTHH:mm:ss", System.Globalization.CultureInfo.InvariantCulture))
            {
                bottomIndexOfSubarray = middleIndex + 1;
            }
            else
            {
                topIndexOfSubarray = middleIndex - 1;
            }
        }

        Debug.Log($"Element {elementToSearch} not found in the array.");
    }
    
}
