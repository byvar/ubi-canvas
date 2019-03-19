using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class AssetDependencyComponent_Template : CSerializable {
		[Serialize("dependencies")] public Placeholder dependencies;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(dependencies));
		}
		public override uint? ClassCRC => 0xF8AC37C3;
	}
}

