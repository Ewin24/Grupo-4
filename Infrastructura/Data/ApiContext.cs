using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructura.Data;

public class ApiContext : DbContext
{
    public ApiContext(DbContextOptions options) : base(options)
    {

    }

    DbSet<Pais> Paises;
    DbSet<Salon> Salones;
    DbSet<Persona> Personas;
    DbSet<Ciudad> Ciudades;
    DbSet<TipoPersona> TipoPersonas;
    DbSet<Matricula> Matriculas;
    DbSet<Departamento> Departamentos;
    DbSet<TrainerSalon> TrainerSalones;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


        modelBuilder.Entity<Pais>(pais =>
        {
            pais.ToTable("Paises");
            pais.HasKey(p => p.Nombre);
            pais.Property(p => p.Nombre).IsRequired();
        });
        modelBuilder.Entity<Ciudad>(ciudad =>
        {
            ciudad.ToTable("Ciudades");
        });
        modelBuilder.Entity<Departamento>(departamento =>
        {
            departamento.ToTable("Ciudades");
        });
    }
}
