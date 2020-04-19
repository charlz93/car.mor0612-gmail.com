using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data = TiendaOnline.DAL.EF;
using ent = TiendaOnline.DO.Objects;
using AutoMapper;

namespace TiendaOnline.Maps
{
    public class Maps
    {
        public static void CreateMaps()
        {
            Mapper.Initialize(cfg =>
            {
                //Categoria
                cfg.CreateMap<ent.Categoria, data.Categoria>();
                cfg.CreateMap<data.Categoria, ent.Categoria>();

                //Estado
                cfg.CreateMap<ent.Estado, data.Estado>();
                cfg.CreateMap<data.Estado, ent.Estado>();

                //Factura
                cfg.CreateMap<ent.Factura_cab, data.Factura_cab>();
                cfg.CreateMap<data.Factura_cab, ent.Factura_cab>();                
                
                //Factura
                cfg.CreateMap<ent.Factura_lin, data.Factura_lin>();
                cfg.CreateMap<data.Factura_lin, ent.Factura_lin>();

                //Producto
                cfg.CreateMap<ent.Producto, data.Producto>();
                cfg.CreateMap<data.Producto, ent.Producto>();

                //Promociones
                cfg.CreateMap<ent.Promociones, data.Promocione>();
                cfg.CreateMap<data.Promocione, ent.Promociones>();

                //Registro
                cfg.CreateMap<ent.Registro, data.Registro>();
                cfg.CreateMap<data.Registro, ent.Registro>();

                //Usuario
                cfg.CreateMap<ent.Usuario, data.Usuario>();
                cfg.CreateMap<data.Usuario, ent.Usuario>();

            });

        }
    }
}
