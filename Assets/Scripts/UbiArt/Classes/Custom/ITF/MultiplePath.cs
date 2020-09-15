using UnityEngine;

namespace UbiArt.ITF {
	public partial class MultiplePath : CSerializable {
		public CList<Path> PathValues;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			PathValues = s.SerializeObject<CList<Path>>(PathValues, name: "PathValues");
		}
	}
}

