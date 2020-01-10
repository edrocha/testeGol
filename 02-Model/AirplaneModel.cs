using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Model
{
    public class AirplaneModel
    {
        [Key]
        public int AIRCodigo { get; set; }

        public string AIRModelo { get; set; }

        public int AIRQtd { get; set; }

        public DateTime AIRData { get; set; }

    }
}
