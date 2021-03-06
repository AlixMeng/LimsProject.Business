﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LimsProject.BusinessLayer;

namespace LimsProject.BusinessLayer.Modules
{
    public class ModCorrelatives
    {
        

        public string CompleteZeros(long number, short num_digits)
        {
            string num = number.ToString();
            return num.PadLeft(num_digits, '0');
        }

        string GetFormatCorrelative(string type_correlative, long? code_value)
        {
            CCorr_modulesFactory faCorr_module = new CCorr_modulesFactory();
            CCorr_modules oModule = faCorr_module.GetByPrimaryKey(new CCorr_modulesKeys(type_correlative));

            return oModule.Prefix + oModule.Cod_serie + "-" + CompleteZeros(Convert.ToInt64(code_value), Convert.ToInt16(oModule.Num_digits));
        }        

        long GetNewCorrelative(string type_correlative)
        {
            CCorr_modulesFactory faCorr_module = new CCorr_modulesFactory();
            CCorr_modules oModule = faCorr_module.GetByPrimaryKey(new CCorr_modulesKeys(type_correlative));

            oModule.Correlative = oModule.Correlative + 1;
            faCorr_module.Update(oModule);
            return Convert.ToInt16(oModule.Correlative);
        }

        public string GetCorrelative(Comun.Correlative corr)
        {
            string code = "";
            string nameCorr = corr.GetDescription();
            code = GetFormatCorrelative(nameCorr, GetNewCorrelative(nameCorr));

            return code;
        }
    }
}
