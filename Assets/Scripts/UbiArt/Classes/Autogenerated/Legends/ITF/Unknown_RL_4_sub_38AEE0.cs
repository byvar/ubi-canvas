using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.COL)]
	public partial class Unknown_RL_4_sub_38AEE0 : SoundCommand {
		[Serialize("buslist")] public CList<StringID> buslist;
		[Serialize("volume" )] public Volume volume;
		[Serialize("time"   )] public float time;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(buslist));
			SerializeField(s, nameof(volume));
			SerializeField(s, nameof(time));
		}
		public override uint? ClassCRC => 0x7ACD5ABF;
	}
}

