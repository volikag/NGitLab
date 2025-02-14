﻿using System;
using System.ComponentModel.DataAnnotations;

namespace NGitLab.Models
{
    public class FileUpsert
    {
        [Required]
        public string Path;

        [Required]
        public string Branch;

        public string Encoding;

        [Required]
        public string Content;

        /// <summary>
        /// Use this setter to set the content as base 64.
        /// </summary>
        public string RawContent
        {
            set
            {
                Content = Base64Encode(value);
                Encoding = "base64";
            }
        }

        [Required]
        public string CommitMessage;

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }
    }
}
