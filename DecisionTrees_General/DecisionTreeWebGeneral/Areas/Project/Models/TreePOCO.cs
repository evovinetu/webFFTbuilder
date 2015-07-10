﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DecisionTreeWebGeneral.Areas.Project.Models
{
    [DataContract(IsReference = true)]
    public class TreePOCO
    {
        #region Properties
        [DataMember(IsRequired = true)]
        public Guid Id { get; set; }
        [DataMember(IsRequired = true)]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
        public ICollection<WorldPOCO> attributes { get; set; }
        #endregion

        #region C'tor
        public TreePOCO() { }
        public TreePOCO(Guid id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public TreePOCO(Guid id, string name, string description) : this()
        {
            this.Description = description;
        }
        #endregion
    }
}