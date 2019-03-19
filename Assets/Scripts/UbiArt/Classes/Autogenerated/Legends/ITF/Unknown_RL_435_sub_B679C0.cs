using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_435_sub_B679C0 : CSerializable {
		[Serialize("AMDisplayTuto")] public bool AMDisplayTuto;
		[Serialize("AM_MapId"     )] public Enum_AM_MapId AM_MapId;
		[Serialize("activated"    )] public int activated;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(AMDisplayTuto), boolAsByte: true);
				SerializeField(s, nameof(AM_MapId));
			}
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(activated));
			}
		}
		public enum Enum_AM_MapId {
			[Serialize("Value__1")] Value__1 = -1,
		}
		public override uint? ClassCRC => 0xF84EA47C;
	}
}

