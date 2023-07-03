﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EmprestimoLivros.API.Models
{
    public partial class Livro
    {
        public Livro()
        {
            LivroCliente = new HashSet<LivroCliente>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("livroNome")]
        [StringLength(50)]
        [Unicode(false)]
        public string LivroNome { get; set; }
        [Required]
        [Column("livroAutor")]
        [StringLength(200)]
        [Unicode(false)]
        public string LivroAutor { get; set; }
        [Required]
        [Column("livroeditora")]
        [StringLength(100)]
        [Unicode(false)]
        public string Livroeditora { get; set; }
        [Column("livroAnoPublicacao", TypeName = "datetime")]
        public DateTime LivroAnoPublicacao { get; set; }
        [Required]
        [Column("livroEdicao")]
        [StringLength(50)]
        [Unicode(false)]
        public string LivroEdicao { get; set; }

        [InverseProperty("LceIdLivroNavigation")]
        public virtual ICollection<LivroCliente> LivroCliente { get; set; }
    }
}