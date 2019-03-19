using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BreakablePropsManagerComponent : ActorComponent {
		[Serialize("lumsGiven"          )] public uint lumsGiven;
		[Serialize("lumsDrcGiven"       )] public uint lumsDrcGiven;
		[Serialize("breakablePropsState")] public CList<uint> breakablePropsState;
		[Serialize("breakablePropsPaint")] public CArray<bool> breakablePropsPaint;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(lumsGiven));
				SerializeField(s, nameof(lumsDrcGiven));
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(breakablePropsState));
					SerializeField(s, nameof(breakablePropsPaint));
				}
			} else {
				SerializeField(s, nameof(lumsGiven));
				SerializeField(s, nameof(lumsDrcGiven));
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(breakablePropsState));
				}
				SerializeField(s, nameof(breakablePropsPaint));
				SerializeField(s, nameof(breakablePropsPaint));
			}
		}
		public override uint? ClassCRC => 0xF2DC9CA7;
	}
}

