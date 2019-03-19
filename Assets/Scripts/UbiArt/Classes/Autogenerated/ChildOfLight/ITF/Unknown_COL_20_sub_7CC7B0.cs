using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class Unknown_COL_20_sub_7CC7B0 : CSerializable {
		[Serialize("clothPath"        )] public Path clothPath;
		[Serialize("collisionDataPath")] public Path collisionDataPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(clothPath));
			SerializeField(s, nameof(collisionDataPath));
		}
		public override uint? ClassCRC => 0x14560C3D;
	}
}

