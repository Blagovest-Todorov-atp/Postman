﻿using System.Collections.Generic;

namespace MediaStore.Demo.API.Models
{
    public class MediaTypes
    {
        public MediaTypes() => Tracks = new HashSet<Tracks>();

        public long MediaTypeId { get; set; }
        public string Name { get; set; }

        public ICollection<Tracks> Tracks { get; set; }
    }
}
