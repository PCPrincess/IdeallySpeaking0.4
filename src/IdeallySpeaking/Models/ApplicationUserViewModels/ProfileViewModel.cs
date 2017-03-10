﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdeallySpeaking.Models.ApplicationUserViewModels
{
    [Authorize]
    public class ProfileViewModel
    {
        [RegularExpression(@"^[a-zA-Z0-9\s]*$", ErrorMessage = "Last name must be alpha characters only.")]
        [MinLength(3)]
        [MaxLength(16)]
        public string UserName { get; set; }

        [Display(Name = "Joined")]
        public DateTime JoinDate { get; private set; }

        [Url]
        public string Url { get; set; }

        public IFormFile Avatar { get; set; }

        public List<Badge> BadgeList { get; set; }

        

        

        

    }
}


