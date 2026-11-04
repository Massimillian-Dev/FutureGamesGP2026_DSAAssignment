using System.Collections.Generic;
using Environment.Tasks;
using System.Threading.Tasks;
using UnityEngine;




namespace Environment.Tasks {
    [CreateAssetMenu(fileName = "Read Json", menuName = "Read Json")]
    public class ReadJson : Task {
        [SerializeField] TextAsset jsonFile;
        public override void Execute() {

            if(jsonFile == null) return;

            Employee[] employees = JsonUtility.FromJson<EmployeeArray>(jsonFile.text)?.employees;
            EmployeeGovenor.instance.allEmployees = employees;

            if(employees == null || employees.Length <= 0) return;
        }
    }
}




//namespace Environment.Tasks {
//    [CreateAssetMenu(fileName = "Read Json", menuName = "Read Json")]
//    public class ReadJson : Task {
//        [SerializeField] TextAsset jsonFile;
//        public override void Execute() {
//
//            if(jsonFile == null) return;
//
//            Employee[] employees = JsonUtility.FromJson<EmployeeArray>(jsonFile.text)?.employees;
//            EmployeeGovenor.instance.allEmployees = employees;
//
//            if(employees == null || employees.Length <= 0) return;
//            Debug.Log("JsonFileRead and outputted to new task");
//        }
//
//    }
//}



//[SerializedField]
//private TextAsset jsonFile = null;
//
//JsonUtility.FromJson<>(jsonFile.text);

//public class student {
//    [SerializeField] public string name;
//    public bool hasGraduated;
//}
//
//public class StudentArray {
//    [SerializableField]
//    public Student[] students;
//}
