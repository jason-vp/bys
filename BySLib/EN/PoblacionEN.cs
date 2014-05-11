using System;


public class PoblacionEN: ENProvincia{

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
