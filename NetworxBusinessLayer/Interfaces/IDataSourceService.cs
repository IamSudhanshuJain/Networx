using NetworxDataLayer.Entities;
using NetworxDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworxBusinessLayer.Interfaces
{
    public interface IDataSourceService
    {
         IEnumerable<StatusModel> GetEmployeeStatus();
    }
}
