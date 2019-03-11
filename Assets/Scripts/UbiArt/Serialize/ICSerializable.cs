using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UbiArt {
	public interface ICSerializable {
		void Serialize(CSerializerObject s, string name);
	}
}
