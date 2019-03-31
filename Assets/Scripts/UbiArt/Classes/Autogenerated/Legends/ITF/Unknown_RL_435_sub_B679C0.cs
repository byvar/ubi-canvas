using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_435_sub_B679C0 : ActorComponent {
		[Serialize("AMDisplayTuto")] public bool AMDisplayTuto;
		[Serialize("AM_MapId"     )] public StringID AM_MapId;
		[Serialize("activated"    )] public bool activated;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.isCatchThemAll) return;
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(AMDisplayTuto), boolAsByte: true);
				if (s.HasFlags(SerializeFlags.Editor)) {
					SerializeFieldAsChoiceList(s, nameof(AM_MapId), "invalid");
				} else {
					SerializeField(s, nameof(AM_MapId));
				}
			}
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(activated));
			}
		}
		public override uint? ClassCRC => 0xF84EA47C;
	}
}

