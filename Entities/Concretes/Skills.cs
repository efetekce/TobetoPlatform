﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Request
{
<<<<<<<< Updated upstream:Entities/Concretes/Skills.cs
    public class Skills : Entity<int>
    {
        public int ProfileId { get; set; }
        public string Skill { get; set; }
========
    public class CreateForeignLanguageRequest
    {
        public string Name { get; set; }
        public int Priority { get; set; }
     
>>>>>>>> Stashed changes:Business/Dtos/Request/CreateForeignLanguageRequest.cs
    }

}
