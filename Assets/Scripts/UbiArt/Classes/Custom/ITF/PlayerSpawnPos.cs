using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RO)]
	public partial class PlayerSpawnPos : CSerializable {
		[Serialize("playerID")] public StringID playerID;
		[Serialize("offset"  )] public Vector2 offset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(playerID));
			SerializeField(s, nameof(offset));
		}
	}
}