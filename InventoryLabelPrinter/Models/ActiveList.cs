using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InventoryLabelPrinter.Models
{
	public class ActiveList
	{		

		[ReadOnly(true)]
		[DisplayName("Code")]
		public int activo { get; set; }

		[ReadOnly(true)]
		[DisplayName("Description")]
		public string descripcion { get; set; }

		[ReadOnly(true)]
		[System.ComponentModel.Browsable(false)]
		public int codTipo { get; set; }

		[ReadOnly(true)]
		[DisplayName("Type")]
		public string tipo { get; set; }

		[ReadOnly(true)]
		[System.ComponentModel.Browsable(false)]
		public int codGrupo { get; set; }

		[ReadOnly(true)]
		[DisplayName("Group")]
		public string grupo { get; set; }

		[ReadOnly(true)]
		[DisplayName("Serie")]
		public string serie { get; set; }
	}
}
