using System;
using BySLib.CAD;

namespace BySLib.CAD{

public class ProvinciaEN: Object , IDisposable{


      #region IDisposable Members

        private bool disposed = false;
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                }
            }
            this.disposed = true;
        }
        ~ProvinciaEN()
        {
            this.Dispose(false);
        }

        #endregion
 int cod_provincia;
 string nombre;
 
 public String Nombre{
	get{return nombre;}
	set{nombre = value;}
 }

 public int Cod_provincia{
	get{return cod_provincia;}
	set{cod_provincia = value;}
 }
 public bool insertarProvincia{
  ProvinciaCAD prov = new ProvinciaCAD();
  return prov.ListarProvincia();

 }
 public  void ActualizarProvincia{
 CADProvioncia prov = new CADProvincia();
 prov.ActualizarProvincia(this);

 }

 public ProvinciaCAD BorrarProvincia (int id){
  
  CADProvioncia prov = new ProvinciaCAD();
  return prov.BorrarProvincia(id);
 }
  public ArrayList listarProvincia{
  
  CADProvioncia prov = new CADProvincia();
  return prov.ListarProvincia();
 }

}
}