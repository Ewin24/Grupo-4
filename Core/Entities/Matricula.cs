using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;
public class Matricula : BaseEntity
{
    public Persona IdPersona { get; set; }
}