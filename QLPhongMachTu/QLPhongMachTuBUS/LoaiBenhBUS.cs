﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLPhongMachTuDAO;
using QLPhongMachTuDTO;

namespace QLPhongMachTuBUS
{
    public class LoaiBenhBUS
    {
        LoaiBenhDAO nvDAO = new LoaiBenhDAO();

        public DataTable LoadData()
        {
            return nvDAO.LoadData();
        }

        public Int64 Insert(LoaiBenhDTO _nv)
        {
            return nvDAO.Insert(_nv);
        }

        public Int64 Update(LoaiBenhDTO _nv)
        {
            return nvDAO.Update(_nv);
        }

        public Int64 Delete(LoaiBenhDTO _nv)
        {
            return nvDAO.Delete(_nv.id);
        }

        public Int64 Delete(int _id)
        {
            return nvDAO.Delete(_id);
        }
    }
}
