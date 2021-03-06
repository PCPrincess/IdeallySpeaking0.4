﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace IdeallySpeaking.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public int ApplicationUserId { get; internal set; }

        [Display(Name = "First name")]
        [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "First name must be alpha characters only.")]
        public string FirstName { get; set; }

        [Display(Name = "Last name")]
        [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Last name must be alpha characters only.")]
        public string LastName { get; set; }

        public string FullName { get { return (FirstName + " " + LastName); } } 
        
        public Profile Profile { get; set; }

        public bool IsOnTimeOut { get; private set; }

        public bool IsEightySixed { get; private set; }

        public DateTime StatusChangeDate { get; set; }

        [InverseProperty("Author")]
        public List<Article> AuthoredArticles { get; }

        public void AddArticleToList(Article article)
        {
            AuthoredArticles.Add(article);
        }

        public List<Comment> UserCommentList { get; }        

        public List<Badge> BadgeList { get; set; }

        public void AddBadgeToList(Badge badge)
        {
            BadgeList.Add(badge);
        }

    }
}


