﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPANY_MANAGEMENT.OOP
{
    class ProcessJobDAO
    {
        DBConn dB = new DBConn();

        public ProcessJob Search(string id)
        {
            string sqlStr = string.Format("SELECT * FROM ProcessJob WHERE IDJob = '{0}';", id);
            return dB.FindProcessJob(sqlStr);
        }

        public void Insert(Job job)
        {
            string sqlStr = string.Format("INSERT INTO ProcessJob(IDJob,Content,Process) values ('{0}','{1}',{2})"
                , job.ID, job.Name, 0);
            dB.Executive(sqlStr);
        }
    }
}