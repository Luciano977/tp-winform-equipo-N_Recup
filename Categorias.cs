using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_EquipoN
{
    internal class Categorias
    {
        /*
        CREATE TABLE[dbo].[CATEGORIAS]
        (
            [Id][int] IDENTITY(1,1) NOT NULL,
            [Descripcion] [varchar] (50) NULL,
             CONSTRAINT[PK_CATEGORIAS] PRIMARY KEY CLUSTERED
        */
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
}
