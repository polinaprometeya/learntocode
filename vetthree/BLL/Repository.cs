using System.Data;
using DAL;
namespace BLL;


public class Repository
{
    public List<Patient> GetPatients()
    {
        List<Patient> patientTable = new List<Patient>();
        var DataAccess = new DAL.DataAccess();

        List<DAL.Patient> dalPatients = DataAccess.getData();
        foreach (var item in dalPatients)
        {
            patientTable.Add(new Patient
            {
                id_animal = item.id_animal,
                name_animal = item.name_animal,
                date_birth = item.date_birth,
                type_animal = item.type_animal,
                id_customer = item.id_customer
            });
        }
        return patientTable;
    }



}

