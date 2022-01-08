using First_WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_WebApplication.Data
{
    public class LocalData
    {

        private static List<Articulos> ListadoArticulosLocal;


        public List<Articulos> GetInstance()
        {
            if (ListadoArticulosLocal != null)
            {
                return ListadoArticulosLocal;
            }
            else
            {
                ListadoArticulosLocal = new List<Articulos>();
                return ListadoArticulosLocal;
            }


        }

        public void SetInstance(List<Articulos> instnacia)
        {
            ListadoArticulosLocal = instnacia;

        }


    }
}
