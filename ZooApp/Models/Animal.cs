﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ZooApp.Models
{
    public class Animal
    {
        [Key] public int AnimalId { get; set; }

        public string Name { get; set; }

        public string Species { get; set; }

        public int Age { get; set; }

        public char Sex { get; set; }

        public DietType Diet { get; set; }


        public int EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        public Employee Employee { get; set; }


        public int EnclosureId { get; set; }
        [ForeignKey(nameof(EnclosureId))]
        public Enclosure Enclosure { get; set; }


        public ICollection<AnimalEmployee> AnimalZooEmployees { get; set; }

    }

    public enum DietType
    {
        Carnivore,
        Omnivore,
        Herbivore,
        Pescatarian
    }
}