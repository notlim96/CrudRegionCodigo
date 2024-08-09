using Data;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class RegionBusiness
    {
        //instanciamos  la capa dtaos
        RegionData dregion = new RegionData();
        public string RegistrarRegionBusiness(RegionEntity regionentity)
        {
            //  realizamos validaciones  
            string message = string.Empty;

            //  valdimaos aue nosea  mayo a 5 carateres
            if (regionentity.RegionName.Length > 5)
            {
                message = "Nombre de la  region muy extensa";
                return message;
            }

            //  validmao que no existe en al BD
            int exist = dregion.ListarRegionData(regionentity).Count;
            if(exist > 0)
            {
                message = "EXISTE EL NO BRE DE REGION EN LA BD";
                return message;
            }

            dregion.RegistrarRegionData(regionentity);
            message = "Succesful";


            return message;
        }

        public List<RegionEntity> ListarRegionBusiness(RegionEntity regionentity)
        {
            try
            {
                List<RegionEntity> lista =  new List<RegionEntity>();
                RegionData dato = new RegionData();

                lista = dato.ListarRegionData(regionentity);

                return lista;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void ActualizarRegionBusiness(RegionEntity regionEntity)
        {
            try
            {
                RegionData data =  new RegionData();
                data.ActualizarRegionData(regionEntity);
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public void EliminarRegionBusiness(RegionEntity regionEntity)
        {
            try
            {
                RegionData data =  new RegionData();
                data.EliminarRegionData(regionEntity);
            }
            catch( Exception ex )
            {
                throw;
            }
        }
    }
}
