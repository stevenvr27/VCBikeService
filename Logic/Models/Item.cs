using Logic.Services;
using System;
using System.Data.SqlClient;
using System.Data;

namespace Logic.Models
{
    public class Item
    {
        //atributos 
        public int ItemID { get; set; }
        public string ItemName { get; set; }

        public string Description { get; set; }
        public string Barcode { get; set; }
        public int Stock { get; set; }
        public decimal UnitaryCost { get; set; }

        public decimal SellPrice { get; set; }

        public bool Active { get; set; }

        //atributos compuestos 
        public Buy Buy { get; set; }
        public ItemCategory MyType { get; set; }   
        public Tax Tax { get; set; }
        public Unit Unit { get; set; }



        //constructor 
        public Item()
        {
            MyType = new ItemCategory();
            Tax = new Tax();
            Unit = new Unit();
            Buy = new Buy();
        }
        // metodo agregar y su respectivo llamado al procedimiento almacenado 
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
            connection.parameterlist.Add(new SqlParameter("@Tax", this.Tax.TaxID));
            connection.parameterlist.Add(new SqlParameter("@Unit", this.Unit.IDUnit));

            int result = connection.EjecutarInsertUpdateDelete("SPAddItem");

            if (result > 0)
            {
                R = true;
            }
            return R;

        }
        // metodo actualizar y su respectivo llamado al procedimiento almacenado 
        public bool Update()
        {
            bool R = false;
            Connection connection = new Connection();
            connection.parameterlist.Add(new SqlParameter("@ItemCategoryID", this.MyType.ItemCategoryID));
            connection.parameterlist.Add(new SqlParameter("@ItemName", this.ItemName));
            connection.parameterlist.Add(new SqlParameter("@Barcode", this.Barcode));
            connection.parameterlist.Add(new SqlParameter("@Stock", this.Stock));
            connection.parameterlist.Add(new SqlParameter("@UnitaryCost", this.UnitaryCost));
            connection.parameterlist.Add(new SqlParameter("@SellPrice", this.SellPrice));
            connection.parameterlist.Add(new SqlParameter("@ITemID", this.ItemID));  
            connection.parameterlist.Add(new SqlParameter("@Tax", this.Tax.TaxID));
            connection.parameterlist.Add(new SqlParameter("@Unit", this.Unit.IDUnit));
            int result = connection.EjecutarInsertUpdateDelete("SPItemUpdate");

            if (result > 0)
            {
                R = true;
            }
            return R;
        }
        public bool Updates()
        {
            bool R = false;
            Connection connection = new Connection();
            connection.parameterlist.Add(new SqlParameter("@ItemCategoryID", this.MyType.ItemCategoryID));
            connection.parameterlist.Add(new SqlParameter("@ItemName", this.ItemName));
            connection.parameterlist.Add(new SqlParameter("@Barcode", this.Barcode));
            connection.parameterlist.Add(new SqlParameter("@Stock", this.Stock)); 
            connection.parameterlist.Add(new SqlParameter("@SellPrice", this.SellPrice));
            connection.parameterlist.Add(new SqlParameter("@ITemID", this.ItemID));
            connection.parameterlist.Add(new SqlParameter("@Tax", this.Tax.TaxID));
            connection.parameterlist.Add(new SqlParameter("@Unit", this.Unit.IDUnit));
            int result = connection.EjecutarInsertUpdateDelete("SPItemUpdates");

            if (result > 0)
            {
                R = true;
            }
            return R;
        }
        public bool UpdateStock()
        {
            bool R = false;
            Connection connection = new Connection();
            connection.parameterlist.Add(new SqlParameter("@ITemID", this.ItemID));
            connection.parameterlist.Add(new SqlParameter("@Stock", this.Stock)); 
            int result = connection.EjecutarInsertUpdateDelete("SPItemUpdatestock");

            if (result > 0)
            {
                R = true;
            }
            return R;
        }

        // metodo eliminar y su respectivo llamado al procedimiento almacenado 
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
        // datatable me trae la lista de items activos mientras activo=true 
        public DataTable ListActive(string pFiltroBusqueda)
        {
            DataTable R = new DataTable();

            Connection Micnn = new Connection();

            Micnn.parameterlist.Add(new SqlParameter("@VerActivo", true));
            Micnn.parameterlist.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));
            R = Micnn.EjecutarSELECT("SPListItemActive");

            return R;
        }
        // datatable me trae la lista de los item con sus precios  precios  
        public DataTable ListActiveSellPrice(string pFiltroBusqueda)
        {
            DataTable R = new DataTable();

            Connection Micnn = new Connection();

            Micnn.parameterlist.Add(new SqlParameter("@VerActivo", true));
            Micnn.parameterlist.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));
            R = Micnn.EjecutarSELECT("SPListItemSellPrice");

            return R;
        }
        // datatable me trae la lista de los item con el precio de costo 
        public DataTable ListUnitaryCost(string pFiltroBusqueda)
        {
            DataTable R = new DataTable();

            Connection Micnn = new Connection();

            Micnn.parameterlist.Add(new SqlParameter("@VerActivo", true));
            Micnn.parameterlist.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));
            R = Micnn.EjecutarSELECT("SPListItemUnitaryCost");

            return R;
        }



        // datatable me trae la lista de items inactivos mientras activo=false
        public DataTable ListInactive(string pFiltroBusqueda)
        {
            DataTable R = new DataTable();
            Connection Micnn = new Connection();

            Micnn.parameterlist.Add(new SqlParameter("@VerActivo", false));
            Micnn.parameterlist.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));
            R = Micnn.EjecutarSELECT("SPListItemActive");
            return R;
        }
        // datatable me trae la lista de los precios activos 
        public DataTable ListActiveProduct(string pFiltroBusqueda)
        {
            DataTable R = new DataTable();

            Connection Micnn = new Connection();

            Micnn.parameterlist.Add(new SqlParameter("@VerActivo", true));
            Micnn.parameterlist.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));
            R = Micnn.EjecutarSELECT("SPListActiveProduct");

            return R;
        }
        public  int ObtenerStockDesdeBaseDeDatos(int itemID)
        {
            int stock = 0;

            Connection connection = new Connection();
            connection.parameterlist.Add(new SqlParameter("@ItemID", itemID));

            DataTable dtStock = connection.EjecutarSELECT("SP_ObtenerStockPorItemID");

            if (dtStock.Rows.Count > 0)
            {
                stock = Convert.ToInt32(dtStock.Rows[0]["Stock"]);
            }

            return stock;
        }
        public bool ActualizarStockEnBaseDeDatos(int itemID, int nuevoStock, decimal nuevoUnitaryCost)
        {
            bool resultado = false;

            Connection connection = new Connection();
            connection.parameterlist.Add(new SqlParameter("@ItemID", itemID));
            connection.parameterlist.Add(new SqlParameter("@Stock", nuevoStock));
            connection.parameterlist.Add(new SqlParameter("@UnitaryCost", nuevoUnitaryCost));

            int result = connection.EjecutarInsertUpdateDelete("SPItemRefresh");

            if (result > 0)
            {
                resultado = true;
            }

            return resultado;
        }
        




        // datatable me lista el productor seleccionado 
        public DataTable ListarEnBusqueda()
        {
            DataTable R = new DataTable();

            Connection MiCnn = new Connection();

            R = MiCnn.EjecutarSELECT("SPProductoBusquedaListar");

            return R;
        }

        // metodo buscar id y retornar atributos del item
        public Item SearchIDReturnItem()
        {
            Item R = new Item();
            Connection Micnn = new Connection();

            Micnn.parameterlist.Add(new SqlParameter("@ID", this.ItemID));

            DataTable dt = new DataTable();

            dt = Micnn.EjecutarSELECT("SPConsultITemID ");

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

                R.Tax.TaxID = Convert.ToInt32(dr["TaxID"]);
                R.Unit.IDUnit = Convert.ToInt32(dr["IDUnit"]);
                R.MyType.ItemCategoryID = Convert.ToInt32(dr["ItemCategoryID"]);
             



            }



            return R;

        }

        public Item SearchItemandBuy()
        {
            Item R = new Item();
            Connection Micnn = new Connection();

            Micnn.parameterlist.Add(new SqlParameter("@ID", this.ItemID));

            DataTable dt = new DataTable();

            dt = Micnn.EjecutarSELECT("SPSearchItemandBuy");

            if (dt != null && dt.Rows.Count > 0)
            {

                DataRow dr = dt.Rows[0];

                R.ItemID = Convert.ToInt32(dr["ItemID"]);
                R.ItemName = Convert.ToString(dr["ItemName"]);
                R.Stock = Convert.ToInt32(dr["Stock"]);
                R.UnitaryCost = Convert.ToDecimal(dr["UnitaryCost"]);

                 

            }



            return R;

        }



        //metodo consultar por ID 
        public Item ConsultarPorID(int pIdProducto)
        {
            Item R = new Item();
            Connection Micnn = new Connection();

            Micnn.parameterlist.Add(new SqlParameter("@ID", pIdProducto));

            DataTable dt = new DataTable();

            dt = Micnn.EjecutarSELECT("SPTemIDConsultI");

            if (dt != null && dt.Rows.Count > 0)
            {

                DataRow MisDatos = dt.Rows[0];
                R.ItemID = Convert.ToInt32(MisDatos["ItemID"]);
                R.ItemName = Convert.ToString(MisDatos["ItemName"]);
                R.Stock = Convert.ToInt32(MisDatos["Stock"]);
                R.SellPrice = Convert.ToDecimal(MisDatos["SellPrice"]);
                R.Tax.TaxID = Convert.ToInt32(MisDatos["TaxID"]);
                R.MyType.ItemCategoryID = Convert.ToInt32(MisDatos["ItemCategoryID"]);
                R.MyType.Description = Convert.ToString(MisDatos["Description"]);
                R.Unit.IDUnit = Convert.ToInt32(MisDatos["IDUnit"]);
                R.Barcode = Convert.ToString(MisDatos["Barcode"]);
                R.Unit.UnitMeasurement = Convert.ToString(MisDatos["UnitMeasurement"]);
                R.Tax.TaxID = Convert.ToInt32(MisDatos["TaxID"]);
                R.Tax.TaxName = Convert.ToString(MisDatos["TaxName"]);
                R.Tax.AmountTax = Convert.ToDecimal(MisDatos["AmountTax"]);
            }

            return R;
        }
        //datatable me busca el ID
        public DataTable SearchID()
        {
            DataTable R = new DataTable();
            Connection connection = new Connection();

            R = connection.EjecutarSELECT("SPSearchID");

            return R;

        } 
        //datatable me lista el item comprado 
        public DataTable newbuy()
        {
            DataTable R = new DataTable();
             Connection connection = new Connection();
        
            R = connection.EjecutarSELECT("SPListItemToBuy");

            return R;
          
        }
        //metodo activar 
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
        //metodo eliminar para siempre de la bd 
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
        //metodo consultar por el codigo de barras 
        public bool ConsultBarcode()
        {
            bool R = false;
            Connection MiCnn = new Connection();

     
            MiCnn.parameterlist.Add(new SqlParameter("@Barcode", this.Barcode));

            DataTable consulta = new DataTable();
            
            consulta = MiCnn.EjecutarSELECT("SPItemSearchForBarcode");

            //paso 1.4.5
            if (consulta != null && consulta.Rows.Count > 0)
            {
                R = true;
            }

            return R;


        }
        //metodo consulta por el ID
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
