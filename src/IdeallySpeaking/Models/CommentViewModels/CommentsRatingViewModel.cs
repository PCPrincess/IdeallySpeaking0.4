﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdeallySpeaking.Models.CommentViewModels
{
    public class CommentsRatingViewModel
    {
        
        public class CommentsRating
        {
            [Key]
            public int Rating { get; private set; }

            private readonly int _rating = 0;

            public CommentsRating()
            {
                Rating = _rating;
            }

            public void RatingUp()
            {
                Rating += 1; 
            }

            public void RatingDown()
            {
                Rating -= 1;
            }

            public int GetRating
            {
                get { return Rating; }
            }

            public static implicit operator int(CommentsRating v)
            {
                throw new NotImplementedException();
            }
        } 
        
    }
}
