using System;


public class PoblacionEN : Object, IDisposable
{

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

    #region Private Properties
    private int cod_postal;
    private string nombrePoblacion;
    private int cod_provincia;

    #endregion

    #region Getters Setters
    public int Cod_provincia
    {
        get { return cod_provincia; }
        set { cod_provincia = value; }
    }
    public int Cod_postal
    {
        get { return cod_postal; }
        set { cod_postal = value; }
    }
    public string Nombre
    {
        get { return nombrePoblacion; }
        set { nombrePoblacion = value; }
    }

    #endregion

}
