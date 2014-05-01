using System;

public class ProvinciaEN{

 int cod_provincia;
 string nombre;
 
 public String nombre{
	get{return nombre;}
	set{nombre = value;}
 }

 public int cod_provincia{
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
