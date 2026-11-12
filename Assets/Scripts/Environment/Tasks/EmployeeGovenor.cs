using Environment;
using UnityEngine;

public class EmployeeGovenor : MonoBehaviour {
    public static EmployeeGovenor instance;

    public Employee[] allEmployees;

    private void Awake() {
        instance = this;
    }

}
