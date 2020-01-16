﻿using System;
using System.Collections.Generic;

namespace Dating.Api.Dtos
{
    public class UserDetailListDto
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string Gender { get; set; }

        public int Age { get; set; }

        public string KnownAs { get; set; }

        public DateTime Created { get; set; }

        public DateTime LastActivate { get; set; }

        public string Introduction { get; set; }

        public string LookingFor { get; set; }

        public string Interests { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public string PhotoUrl { get; set; }

        public ICollection<PhotoDetailDto> Photos { get; set; }
    }
}