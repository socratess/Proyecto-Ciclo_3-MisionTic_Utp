using System;
namespace MascotaFeliz.App.Dominio
{
public class Mascota{
public int Id { get; set; }
public string Nombre { get; set; }
public string Color { get; set;}
public string Especie { get; set; }
public string Raza { get; set; }
public Dueno dueno { get; set; }
public Veterinario veterinario  { get; set; }
public Historia historia { get; set; }
}
}