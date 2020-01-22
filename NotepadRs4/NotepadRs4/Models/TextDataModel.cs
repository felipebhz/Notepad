﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace NotepadRs4.Models
{
    public class TextDataModel
    {
        public string Text { get; set; }

        public string DocumentTitle { get; set; }

        public StorageFile DataFile { get; set; }
    }
}
