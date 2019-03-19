using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.COL)]
	public partial class Unknown_RL_73_sub_944E30 : CSerializable {
		[Serialize("looping"              )] public int looping;
		[Serialize("startingLeaf"         )] public uint startingLeaf;
		[Serialize("pauseInsensitiveFlags")] public uint pauseInsensitiveFlags;
		[Serialize("looping"              )] public bool looping;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(pauseInsensitiveFlags));
				SerializeField(s, nameof(looping), boolAsByte: true);
				SerializeField(s, nameof(startingLeaf));
			} else {
				SerializeField(s, nameof(looping));
				SerializeField(s, nameof(startingLeaf));
				SerializeField(s, nameof(pauseInsensitiveFlags));
			}
		}
		public override uint? ClassCRC => 0x4A769E62;
	}
}

