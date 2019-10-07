﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace domain.Entities
{
    public class Table : Entity
    {
        [Required(ErrorMessage = "Nome da mesa obrigatório.")]
        public string Name { get; set; }
        public string Description { get; set; }

        [ForeignKey("Master")]
        [Required(ErrorMessage = "É necessário informar um mestre para assumir à mesa.")]
        public int MasterId { get; set; }
        public User Master { get; set; }

        public IList<PlayerTable> PlayerTables { get; set; }
    }
}