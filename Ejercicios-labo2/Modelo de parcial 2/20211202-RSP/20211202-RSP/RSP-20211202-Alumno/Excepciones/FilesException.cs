﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class FilesException : Exception
    {
        public FilesException(string message,Exception innerException)
            :base(message,innerException)
        {

        }
    }
}
