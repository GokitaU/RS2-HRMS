﻿using AutoMapper;
using HRMS.Interfaces;
using HRMS.Models;

namespace HRMS.Services
{
    public class EmployeeService : CrudService<Employee, Model.Employee>, IEmployeeService
    {
        public EmployeeService(
            HRMS_Context context,
            IMapper mapper)
            : base(context, mapper) { }
    }
}