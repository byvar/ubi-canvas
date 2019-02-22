using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITF {
	public class GFX_MaterialParams : BaseObject {
		[Serialize(0, "matParams0F")] public float matParams0F;
		[Serialize(1, "matParams1F")] public float matParams1F;
		[Serialize(2, "matParams2F")] public float matParams2F;
		[Serialize(3, "matParams3F")] public float matParams3F;
		[Serialize(4, "matParams0I")] public int matParams0I;
		[Serialize(5, "matParams0VX")] public float matParams0VX;
		[Serialize(6, "matParams0VY")] public float matParams0VY;
		[Serialize(7, "matParams0VZ")] public float matParams0VZ;
		[Serialize(8, "matParams0VW")] public float matParams0VW;

		public GFX_MaterialParams(Reader reader) : base(reader) {
		}
	}
}
