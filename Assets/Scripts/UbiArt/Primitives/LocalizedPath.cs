using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UbiArt {
	public class LocalizedPath : CSerializable {
		[Serialize("locId"      )] public LocalisationId locId;
		[Serialize("defaultPath")] public Path defaultPath;

		protected override void SerializeImpl(CSerializerObject s) {
			SerializeField(s, nameof(locId));
			SerializeField(s, nameof(defaultPath));
		}
	}
}
