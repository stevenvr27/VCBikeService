using Logic.Services;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    public class Item
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }

        public string Description { get; set; }
        public string Barcode { get; set; }
        public int Stock { get; set; }
        public decimal UnitaryCost { get; set; }

        public decimal SellPrice { get; set; }

        public bool Active { get; set; }
        public ItemCategory MyType { get; set; }    



        public Item()
        {
            MyType = new ItemCategory();
        }
        public bool Add()
        {
            bool R = false;

            Connection connection = new Connection();



            connection.parameterlist.Add(new SqlParameter("@Description", this.Description));
            connection.parameterlist.Add(new SqlParameter("@ItemName", this.ItemName));
            connection.parameterlist.Add(new SqlParameter("@Barcode", this.Barcode));
            connection.parameterlist.Add(new SqlParameter("@Stock", this.Stock));
            connection.parameterlist.Add(new SqlParameter("@UnitaryCost", this.UnitaryCost));
            connection.parameterlist.Add(new SqlParameter("@SellPrice", this.SellPrice));
            connection.parameterlist.Add(new SqlParameter("@ItemCategoryID", this.MyType.ItemCategoryID));

            int result = connection.EjecutarInsertUpdateDelete("SPAddItem");

            if (result > 0)
            {
                R = true;
            }
            return R;

        }
        public bool Update()
        {
            bool R = false;
            Connection connection = new Connection();
            connection.parameterlist.Add(new SqlParameter("@ITemID", this.ItemID));
            connection.parameterlist.Add(new SqlParameter("@Description", this.Description));
            connection.parameterlist.Add(new SqlParameter("@ItemName", this.ItemName));
            connection.parameterlist.Add(new SqlParameter("@Barcode", this.Barcode));
            connection.parameterlist.Add(new SqlParameter("@Stock", this.Stock));
            connection.parameterlist.Add(new SqlParameter("@UnitaryCost", this.UnitaryCost));
            connection.parameterlist.Add(new SqlParameter("@SellPrice", this.SellPrice));
            connection.parameterlist.Add(new SqlParameter("@ItemCategoryID", this.MyType.ItemCategoryID));
            int result = connection.EjecutarInsertUpdateDelete("SPItemUpdate");

            if (result > 0)
            {
                R = true;
            }
            return R;
        }

        public bool Delete()
        {
            bool R = false;
            Connection connection = new Connection();
            connection.parameterlist.Add(new SqlParameter("@ID", this.ItemID));
            int r = connection.EjecutarInsertUpdateDelete("SPItemDesactive");

            if (r > 0)
            {
                R = true;
            }

            return R;

        }

        public DataTable ListActive(string pFiltroBusqueda)
        {
            DataTable R = new DataTable();

            Connection Micnn = new Connection();

            Micnn.parameterlist.Add(new SqlParameter("@VerActivo", true));
            Micnn.parameterlist.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));
            R = Micnn.EjecutarSELECT("SPListItemActive");

            return R;
        }
        public DataTable ListInactive(string pFiltroBusqueda)
        {
            DataTable R = new DataTable();
            Connection Micnn = new Connection();

            Micnn.parameterlist.Add(new SqlParameter("@VerActivo", false));
            Micnn.parameterlist.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));
            R = Micnn.EjecutarSELECT("SPListItemActive");
            return R;
        }
        public DataTable ListActiveProduct(string pFiltroBusqueda)
        {
            DataTable R = new DataTable();

            Connection Micnn = new Connection();

            Micnn.parameterlist.Add(new SqlParameter("@VerActivo", true));
            Micnn.parameterlist.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));
            R = Micnn.EjecutarSELECT("SPListActiveProduct");

            return R;
        }
        
        public Item SearchIDReturnItem()
        {
            Item R = new Item();
            Connection Micnn = new Connection();

            Micnn.parameterlist.Add(new SqlParameter("@ID", this.ItemID));

            DataTable dt = new DataTable();

            dt = Micnn.EjecutarSELECT("SearchIDReturnItem");

            if (dt != null && dt.Rows.Count > 0)
            {

                DataRow dr = dt.Rows[0];

                R.ItemID = Convert.ToInt32(dr["ItemID"]);
                R.ItemName = Convert.ToString(dr["ItemName"]);
                R.Stock= Convert.ToInt32(dr["Stock"]);

                R.Barcode = Convert.ToString(dr["Barcode"]);
                R.UnitaryCost = Convert.ToDecimal(dr["UnitaryCost"]);
                R.SellPrice = Convert.ToDecimal(dr["SellPrice"]);
                R.Description = Convert.ToString(dr["Description"]);


                R.MyType.ItemCategoryID = Convert.ToInt32(dr["ItemCategoryID"]);
             



            }



            return R;

        }
        public DataTable newbuy()
        {
            DataTable R = new DataTable();
             Connection connection = new Connection();
        
            R = connection.EjecutarSELECT("SPNewBuyItem");

            return R;
          
        }
        public bool Activate()
        {
            bool R = false;
            Connection connection = new Connection();
            connection.parameterlist.Add(new SqlParameter("@ID", this.ItemID));
            int r = connection.EjecutarInsertUpdateDelete("SPItemReturnActive ");

            if (r > 0)
            {
                R = true;
            }

            return R;
        }

        public bool DeleteForEver()
        {
            bool R = false;
            Connection connection = new Connection();
            connection.parameterlist.Add(new SqlParameter("@ID", this.ItemID));
            int r = connection.EjecutarInsertUpdateDelete("SPDeleteItem");

            if (r > 0)
            {
                R = true;
            }

            return R;
        }

        public bool ConsultBarcode()
        {
            bool R = false;
            Connection MiCnn = new Connection();

            //agregamos el parametro de correo 
            MiCnn.parameterlist.Add(new SqlParameter("@Email", this.Barcode));

            DataTable consulta = new DataTable();
            //paso 1.4.3 y 1.4.4
            consulta = MiCnn.EjecutarSELECT("SPItemSearchForBarcode");

            //paso 1.4.5
            if (consulta != null && consulta.Rows.Count > 0)
            {
                R = true;
            }

            return R;


        }

        public bool ConsultID()
        {
            bool R = false;
            Connection MiCnn = new Connection();

            //agregamos el parametro de correo 
            MiCnn.parameterlist.Add(new SqlParameter("@ID", this.ItemID));

            DataTable consulta = new DataTable();
            //paso 1.4.3 y 1.4.4
            consulta = MiCnn.EjecutarSELECT("SPItemSearchForID");

            //paso 1.4.5
            if (consulta != null && consulta.Rows.Count > 0)
            {
                R = true;
            }

            return R;


        }


    }
}
