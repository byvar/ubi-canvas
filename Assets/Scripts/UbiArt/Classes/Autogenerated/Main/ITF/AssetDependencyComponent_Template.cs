using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class AssetDependencyComponent_Template : CSerializable {
		public Placeholder dependencies;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			dependencies = s.SerializeObject<Placeholder>(dependencies, name: "dependencies");
		}
		public override uint? ClassCRC => 0xF8AC37C3;
	}
}

