﻿using System;
using Core.Entities;

namespace Entities.DTOs
{
	public class CourseDetailsDto : IDto
	{
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public string? ImageUrl { get; set; }
        public string? CategoryName { get; set; }
    }
}

