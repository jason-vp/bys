using System;


public class PoblacionEN: Object , IDisposable{

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
        ~PoblacionEN()
        {
            this.Dispose(false);
        }

        #endregion


 int cod_postal;
 string nombre;
 
 public String nombre{
	get{return nombre;}
	set{nombre = value;}
 }

 public int cod_postal{
	get{return cod_postal;}
	set{cod_postal = value;}
 }
 public bool insertarPoblacion{
  PoblacionCAD po = new PoblacionCAD();
  return po.ListarPoblacion();

 }
 public void ActualizarProvincia{
 PoblacionCAD po = new PoblacionCAD();
 po.ActualizarPoblacion(this);

 }

 public BorrarPoblacion (int id){
  
  PoblacionCAD po = new PoblacionCAD();
  return po.BorrarPoblacion(id);
 }

  public ArrayList listarPoblacion{
  
  PoblacionCAD po = new PoblacionCAD();
  return po.ListarPoblacion();
 }

}
