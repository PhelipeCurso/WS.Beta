﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LocacaoDeVeiculos.DATA.Models
{
    public partial class Cliente
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Nome { get; set; }
        [Required]
        [Column("CPF")]
        [StringLength(14)]
        [Unicode(false)]
        public string Cpf { get; set; }
        [Required]
        [StringLength(200)]
        [Unicode(false)]
        public string Endereco { get; set; }
        [Required]
        [StringLength(100)]
        [Unicode(false)]
        public string Cidade { get; set; }
        [Required]
        [StringLength(100)]
        [Unicode(false)]
        public string Bairro { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Numero { get; set; }
        [StringLength(14)]
        [Unicode(false)]
        public string TelefoneCelular { get; set; }
        [StringLength(13)]
        [Unicode(false)]
        public string TelefoneFixo { get; set; }

        [InverseProperty("IdNavigation")]
        public virtual ClienteVeiculo ClienteVeiculo { get; set; }
    }
}