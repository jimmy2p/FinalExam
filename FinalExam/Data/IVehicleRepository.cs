using FinalExam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalExam.Data
{
    public interface IVehicleRepository
    {
        IEnumerable<Vehicle> GetAll();

        void Create(Vehicle vehicle);

        void Update(Vehicle vehicle);

        void Delete(int id);
    }
}
