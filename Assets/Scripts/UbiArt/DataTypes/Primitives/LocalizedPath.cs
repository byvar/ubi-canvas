using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UbiArt {
	public class LocalizedPath : CSerializable {
		public LocalisationId locId;
		public Path defaultPath;

		protected override void SerializeImpl(CSerializerObject s) {
			locId = s.SerializeObject<LocalisationId>(locId, name: "locId");
			defaultPath = s.SerializeObject<Path>(defaultPath, name: "defaultPath");
		}
	}
}
