using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BTActionSpawnActor_Template : BTAction_Template {
		[Serialize("ActorPath")] public Path ActorPath;
		[Serialize("Offset"   )] public Vector2 Offset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(ActorPath));
			SerializeField(s, nameof(Offset));
		}
		public override uint? ClassCRC => 0x25E52449;
	}
}

