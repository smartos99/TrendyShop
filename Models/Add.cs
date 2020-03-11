﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TrendyShop.Models
{
    public class Add
    {
        public int UserId { get; set; }

        [ForeignKey("UserId"),Column(Order = 0)]
        public User User { get; set; }

        public int ArticleId { get; set; }

        [Key,ForeignKey("ArticleId"), Column(Order = 1)]
        public Article Article { get; set; }

        public int Amount { get; set; }

        public string Description { get; set; } //Is this necessary??

        public DateTime LastModified { get; set; }

    }
}